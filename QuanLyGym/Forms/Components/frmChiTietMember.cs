using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGym.BUS;
namespace QuanLyGym.Forms.Components
{
    public partial class frmChiTietMember : Form
    {
        private string maKhachHang_NhanDuoc;
        KhachHangBUS khBus = new KhachHangBUS();
        LichBUS lichBUS = new LichBUS();
        LopBus lopBus = new LopBus();
        HuanLuyenVienBUS hlvbus = new HuanLuyenVienBUS();
        GoiTapBUS goiTapBus  = new GoiTapBUS();
        public frmChiTietMember(string maKH)
        {
            InitializeComponent();
            this.btn_DangKyPT.Click += Btn_DangKyPT_Click;
            this.btn_DangKyLop.Click += Btn_DangKyLop_Click;
            this.btnTuanTruoc.Click += this.btnTuanTruoc_Click;
            this.btnTuanSau.Click += this.btnTuanSau_Click;
            this.btn_Goi.Click += Btn_Goi_Click;
            this.btn_LopTap.Click += Btn_LopTap_Click;
            this.btn_HuanLuyenVien.Click += Btn_HuanLuyenVien_Click;

            this.Load += frmChiTietMember_Load;
            this.maKhachHang_NhanDuoc = maKH;
            this.dtpChonNgay.ValueChanged += this.dtpChonNgay_ValueChanged;
            
        }

        private void Btn_HuanLuyenVien_Click(object sender, EventArgs e)
        {
            // 1. Reset màu của tất cả các tab
            ResetTabColors();
            // 2. Đặt màu "active" (màu trắng) cho nút này
            btn_HuanLuyenVien.BackColor = Color.White;
            DataTable dt = hlvbus.GetPT_ByKH(this.maKhachHang_NhanDuoc);

            txt_GoiHLV.ReadOnly = true; 
            txt_TenHLV.ReadOnly = true;
            txt_NgayBatDauGoiTapHLV.ReadOnly = true;
            txt_NgayKetThucGoiTapHLV.ReadOnly = true;

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txt_GoiHLV.Text = row["TenGoi"].ToString();
                txt_TenHLV.Text = row["TenHLV"].ToString();
                txt_NgayBatDauGoiTapHLV.Text = "Từ: " + Convert.ToDateTime(row["NgayBatDau"]).ToString("dd/MM/yyyy");
                txt_NgayKetThucGoiTapHLV.Text = "Đến: " + Convert.ToDateTime(row["NgayHetHan"]).ToString("dd/MM/yyyy");
                btn_DangKyPT.Text = "Gia hạn Gói PT";
            }
            else
            {
                txt_GoiHLV.Text = "Chưa đăng ký gói PT";
                txt_TenHLV.Text = "HLV:";
                txt_NgayBatDauGoiTapHLV.Text = "";
                txt_NgayKetThucGoiTapHLV.Text = "";
                btn_DangKyPT.Text = "Đăng ký Huấn luyện viên";
            }
            pnl_HuanLuyenVien.BringToFront();
        }

        private void Btn_LopTap_Click(object sender, EventArgs e)
        {
            // 1. Reset màu của tất cả các tab
            ResetTabColors();
            // 2. Đặt màu "active" (màu trắng) cho nút này
            btn_LopTap.BackColor = Color.White;
            dgv_DanhSachCacLopHLV.ReadOnly = true;
            dgv_DanhSachCacLopHLV.DataSource = lopBus.GetLop_ByKH(this.maKhachHang_NhanDuoc);
            pnl_LopCuaHoiVien.BringToFront();
        }

        private void Btn_Goi_Click(object sender, EventArgs e)
        {
            // 1. Reset màu của tất cả các tab
            ResetTabColors();
            // 2. Đặt màu "active" (màu trắng) cho nút này
            btn_Goi.BackColor = Color.White;
            DataTable dt = goiTapBus.GetGoiTap_ByKH(this.maKhachHang_NhanDuoc);
            txt_TenGoi.ReadOnly = true;
            
            txt_NgayBatDauGoiTap.ReadOnly = true;
            txt_NgayKetThucGoiTap.ReadOnly = true;
            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txt_TenGoi.Text = row["TenGoi"].ToString();
                txt_NgayBatDauGoiTap.Text = "Từ: " + Convert.ToDateTime(row["NgayBatDau"]).ToString("dd/MM/yyyy");
                txt_NgayKetThucGoiTap.Text = "Đến: " + Convert.ToDateTime(row["NgayHetHan"]).ToString("dd/MM/yyyy");
                // Đã có gói -> Nút này là "Gia hạn"
                btn_DangKyGoi.Text = "Gia hạn Gói tập";
            }
            else
            {
                txt_TenGoi.Text = "Chưa đăng ký gói tập";
                txt_NgayBatDauGoiTap.Text = "";
                txt_NgayKetThucGoiTap.Text = "";
                // Chưa có gói -> Nút này là "Đăng ký mới"
                btn_DangKyGoi.Text = "Đăng ký Gói tập mới";
            }

            pnl_GoiTapCuaHoiVien.BringToFront();

        }

        private void dtpChonNgay_ValueChanged(object sender, EventArgs e)
        {
            // Lấy ngày mới từ DateTimePicker
            DateTime ngayMoi = dtpChonNgay.Value;

            // Gọi hàm tải lịch 
            LoadCalendar(ngayMoi);
        }

        private void btnTuanTruoc_Click(object sender, EventArgs e)
        {
            // 1. Lấy ngày đang hiển thị
            DateTime ngayHienTai = dtpChonNgay.Value;

            // 2. Tính ngày của tuần trước (trừ đi 7 ngày)
            DateTime ngayTuanTruoc = ngayHienTai.AddDays(-7);

            // 3. Gán lại giá trị cho DateTimePicker
            // (Việc này sẽ TỰ ĐỘNG kích hoạt sự kiện "dtpChonNgay_ValueChanged"
            // và gọi LoadCalendar(ngayTuanTruoc))
            dtpChonNgay.Value = ngayTuanTruoc;
        }

        private void btnTuanSau_Click(object sender, EventArgs e)
        {
            // 1. Lấy ngày đang hiển thị
            DateTime ngayHienTai = dtpChonNgay.Value;

            // 2. Tính ngày của tuần sau (cộng thêm 7 ngày)
            DateTime ngayTuanSau = ngayHienTai.AddDays(7);

            // 3. Gán lại giá trị
            dtpChonNgay.Value = ngayTuanSau;
        }

        private void Btn_DangKyLop_Click(object sender, EventArgs e)
        {
            frmDangKyLop frmDangKyLop = new frmDangKyLop();
            frmDangKyLop.ShowDialog();
            
        }

        private void Btn_DangKyPT_Click(object sender, EventArgs e)
        {
           frmDangKyPT frmDangKyHLV = new frmDangKyPT();
            frmDangKyHLV.ShowDialog();

        }

        private void frmChiTietMember_Load(object sender, EventArgs e)
        {
            // Kiểm tra xem có mã được gửi sang không
            if (!string.IsNullOrEmpty(maKhachHang_NhanDuoc))
            {
                // Gọi BUS để lấy dữ liệu
                DataRow row = khBus.GetKH_ById(maKhachHang_NhanDuoc);

                if (row != null)
                {
                    // Đổ dữ liệu lên các TextBox
                    txt_MaHoiVien.Text = row["MaKH"].ToString();
                    txt_HoVaTenHoiVien.Text = row["TenKH"].ToString();
                    txt_NamSinh.Text = row["NamSinh"].ToString();
                    cbo_GioiTinh.Text = row["GioiTinh"].ToString();
                    txt_SDT.Text = row["SDT"].ToString();
                    txt_Email.Text = row["Email"].ToString();
                    cbo_TinhTrang.Text = row["TinhTrang"].ToString();
                    if (row["HinhAnh"] != DBNull.Value && !string.IsNullOrEmpty(row["HinhAnh"].ToString()))
                    {
                        string duongDanAnh = Path.Combine(Application.StartupPath, row["HinhAnh"].ToString());
                        if (File.Exists(duongDanAnh))
                        {
                            pic_PictureMember.Image = new Bitmap(duongDanAnh);
                            pic_PictureMember.SizeMode = PictureBoxSizeMode.StretchImage;
                            pic_PictureMember.BackgroundImage = null;
                        }
                    }

                    SetReadOnlyMode();
                    
                }

                LoadCalendar(DateTime.Now);
                Btn_Goi_Click(null, null);

            }


        }

        // Trong frmChiTietMember.cs
        public void LoadCalendar(DateTime ngayTrongTuan)
        {
            // Tính toán ngày
            DateTime ngayDauTuan = GetStartOfWeek(ngayTrongTuan);
            DateTime ngayCuoiTuan = ngayDauTuan.AddDays(6);

            // Cập nhật Headers
            UpdateHeaders(ngayDauTuan);

            // Xóa lịch cũ (Giữ nguyên)
            ClearAllCells();

            // Lấy dữ liệu (SỬA LẠI DÒNG NÀY)
            // Gửi cả 2 ngày vào
            DataTable dtLop = lichBUS.GetLichLop_ByKH(this.maKhachHang_NhanDuoc, ngayDauTuan, ngayCuoiTuan);

            
            DataTable dtPT = lichBUS.GetLichPT_ByKH(this.maKhachHang_NhanDuoc, ngayDauTuan, ngayCuoiTuan);

            // 5. "Vẽ" lịch 
            foreach (DataRow row in dtLop.Rows)
            {
                VeMotLichHen(row);
            }
            foreach (DataRow row in dtPT.Rows)
            {
                VeMotLichHen(row);
            }
        }

        private void VeMotLichHen(DataRow row)
        {
            // Lấy dữ liệu (GIỮ NGUYÊN)
            string tieuDe = row["TieuDe"].ToString();
            string chiTiet = row["ChiTiet"].ToString();
            string loaiLich = row["LoaiLich"].ToString();
            int thuTrongTuan = Convert.ToInt32(row["ThuTrongTuan"]);
            TimeSpan gioBatDau = (TimeSpan)row["GioBatDau"];

            // LẤY THÊM GIỜ KẾT THÚC
            TimeSpan gioKetThuc = (TimeSpan)row["GioKetThuc"]; // Lấy cột mới

            // TẠO CHUỖI THỜI GIAN (ví dụ: "06:00 - 07:00")
            string thoiGian = string.Format("{0:hh\\:mm} - {1:hh\\:mm}", gioBatDau, gioKetThuc);

            // Tạo Panel "khối" 
            Panel pnlBlock = new Panel
            {
                Width = flpSangThu2.Width - 10,
                Height = 150,
                Margin = new Padding(3),
                BorderStyle = BorderStyle.FixedSingle
            };

            //Tạo Label Tiêu đề 
            Label lblTieuDe = new Label
            {
                Text = tieuDe,
                Font = new Font(this.Font.FontFamily, 8f, FontStyle.Bold),
                Dock = DockStyle.Top,
                AutoSize = false,
                Height = 25,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(2)
            };

            // Tạo Label Chi tiết 
            Label lblChiTiet = new Label
            {
                // THÊM CHUỖI THỜI GIAN VÀO ĐẦU
                Text = thoiGian + "\n" + chiTiet,
                Font = new Font(this.Font.FontFamily, 7f, FontStyle.Regular),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.TopLeft,
                Padding = new Padding(3)
            };

            // Gán màu 
            if (loaiLich == "Lop")
                pnlBlock.BackColor = Color.FromArgb(220, 220, 220);
            else if (loaiLich == "PT")
                pnlBlock.BackColor = Color.FromArgb(200, 255, 200);

            // 8. Thêm Control 
            pnlBlock.Controls.Add(lblChiTiet);
            pnlBlock.Controls.Add(lblTieuDe);
            FlowLayoutPanel cell = GetCell(thuTrongTuan, gioBatDau);
            if (cell != null)
            {
                cell.Controls.Add(pnlBlock);
            }
        }
        private FlowLayoutPanel GetCell(int thuTrongTuan, TimeSpan gioBatDau)
        {
            string caHoc = "Toi";
            if (gioBatDau.Hours < 12) caHoc = "Sang";
            else if (gioBatDau.Hours < 18) caHoc = "Chieu";

            string tenThu = "CN"; // 1
            if (thuTrongTuan == 2) tenThu = "Thu2";
            else if (thuTrongTuan == 3) tenThu = "Thu3";
            else if (thuTrongTuan == 4) tenThu = "Thu4";
            else if (thuTrongTuan == 5) tenThu = "Thu5";
            else if (thuTrongTuan == 6) tenThu = "Thu6";
            else if (thuTrongTuan == 7) tenThu = "Thu7";

            
            // Ví dụ: flpSangThu2, flpChieuThu5, flpToiCN
            string controlName = "flp" + caHoc + tenThu;

            Control[] matches = this.Controls.Find(controlName, true);
            if (matches.Length > 0 && matches[0] is FlowLayoutPanel)
            {
                return (FlowLayoutPanel)matches[0];
            }
            return null;
        }

        private void ClearAllCells()
        {
            
            foreach (Control ctrl in tableLayoutPanel2.Controls)
            {
                if (ctrl is FlowLayoutPanel)
                {
                    ((FlowLayoutPanel)ctrl).Controls.Clear();
                }
            }
        }

        /**
         * Hàm cập nhật ngày cho các Header
         */
        private void UpdateHeaders(DateTime ngayDauTuan)
        {
            // (Giả sử tên Label Header là: lblThu2, lblThu3, ...)
            lblThu2.Text = "Thứ 2\n" + ngayDauTuan.ToString("dd/MM/yyyy");
            lblThu3.Text = "Thứ 3\n" + ngayDauTuan.AddDays(1).ToString("dd/MM/yyyy");
            lblThu4.Text = "Thứ 4\n" + ngayDauTuan.AddDays(2).ToString("dd/MM/yyyy");
            lblThu5.Text = "Thứ 5\n" + ngayDauTuan.AddDays(3).ToString("dd/MM/yyyy");
            lblThu6.Text = "Thứ 6\n" + ngayDauTuan.AddDays(4).ToString("dd/MM/yyyy");
            lblThu7.Text = "Thứ 7\n" + ngayDauTuan.AddDays(5).ToString("dd/MM/yyyy");
            lblCN.Text = "Chủ nhật\n" + ngayDauTuan.AddDays(6).ToString("dd/MM/yyyy");
        }

        /**
         * Hàm tiện ích: Lấy ngày Thứ 2 của tuần
         */
        private DateTime GetStartOfWeek(DateTime dt)
        {
            // (Giả sử tuần bắt đầu từ Thứ 2 - Monday)
            CultureInfo ci = CultureInfo.CurrentCulture;
            DayOfWeek firstDay = DayOfWeek.Monday;

            int offset = dt.DayOfWeek - firstDay;
            if (offset < 0)
            {
                offset += 7;
            }
            return dt.AddDays(-offset);
        }

        private void SetReadOnlyMode()
        {
            this.Text = "Thông tin chi tiết hội viên";

            // Vô hiệu hóa các control
            txt_MaHoiVien.ReadOnly = true;
            txt_HoVaTenHoiVien.ReadOnly = true;
            txt_NamSinh.ReadOnly = true;
            cbo_GioiTinh.Enabled = false;
            txt_SDT.ReadOnly = true;
            txt_Email.ReadOnly = true;
            cbo_TinhTrang.Enabled = false;
            pic_PictureMember.Enabled = false;
        }


        private void ResetTabColors()
        {
            // Đặt TẤT CẢ các nút tab về màu mặc định (màu xám)
            btn_Goi.BackColor = Color.LightGray;
            btn_HuanLuyenVien.BackColor = Color.LightGray;
            btn_LopTap.BackColor = Color.LightGray;
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
