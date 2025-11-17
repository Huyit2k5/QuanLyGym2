using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGym.BUS;

namespace QuanLyGym.Forms.Components
{
    public partial class frmDatLichHLV : Form
    {
        private string maDKPT;
        private DateTime ngayHetHanGoi;
        private DateTime currentWeekStart;

        private HuanLuyenVienBUS hlvBus = new HuanLuyenVienBUS();
        private LichBUS lichBUS = new LichBUS();

        public frmDatLichHLV(string maDKPT, DateTime hanGoi)
        {
            InitializeComponent();
            this.maDKPT = maDKPT;
            this.ngayHetHanGoi = hanGoi;
            this.CenterToParent();

            this.Load += FrmDatLichHLV_Load;
            this.cbo_HuanLuyenVien.SelectedIndexChanged += Cbo_HuanLuyenVien_SelectedIndexChanged;
            this.btn_DangKy.Click += Btn_DangKy_Click;
            this.btnTuanTruoc.Click += BtnTuanTruoc_Click;
            this.btnTuanSau.Click += BtnTuanSau_Click;
            this.dtp_NgayLich.ValueChanged += Dtp_NgayLich_ValueChanged;
        }

        private void Dtp_NgayLich_ValueChanged(object sender, EventArgs e)
        {
            DateTime ngayDangChon = dtp_NgayLich.Value;
            LoadCalendarHLV(ngayDangChon);
        }

        private void BtnTuanSau_Click(object sender, EventArgs e)
        {
            DateTime ngayHienTai = dtp_NgayLich.Value;
            DateTime ngayTuanSau = ngayHienTai.AddDays(7);
            dtp_NgayLich.Value = ngayTuanSau;
            // (Không cần gọi LoadCalendarHLV, vì ValueChanged sẽ tự gọi)
        }

        private void BtnTuanTruoc_Click(object sender, EventArgs e)
        {
            DateTime ngayHienTai = dtp_NgayLich.Value;
            DateTime ngayTuanTruoc = ngayHienTai.AddDays(-7);
            dtp_NgayLich.Value = ngayTuanTruoc;
        }

        private void Btn_DangKy_Click(object sender, EventArgs e)
        {
            if (cbo_HuanLuyenVien.SelectedValue == null) return;

            // 1. LẤY DỮ LIỆU CƠ BẢN
            string maHLV = cbo_HuanLuyenVien.SelectedValue.ToString();
            TimeSpan gioBatDau = dtp_ThoiGianBatDau.Value.TimeOfDay;
            TimeSpan gioKetThuc = dtp_ThoiGianKetThuc.Value.TimeOfDay;

            // Kiểm tra giờ hợp lệ
            if (gioBatDau >= gioKetThuc)
            {
                MessageBox.Show("Giờ kết thúc phải sau giờ bắt đầu!");
                return;
            }

            // 2. XÁC ĐỊNH NGÀY BẮT ĐẦU (MỐC XUẤT PHÁT)
            int indexThu = cbo_NgayTrongTuan.SelectedIndex; // 0=T2, 1=T3...
            DateTime tuanHienTai = currentWeekStart;
            DateTime ngayMuonDat = tuanHienTai.AddDays(indexThu); // Ngày trong tuần này

            // Nếu ngày chọn đã qua (nhỏ hơn hôm nay), nhảy sang tuần sau
            if (ngayMuonDat < DateTime.Today)
            {
                ngayMuonDat = ngayMuonDat.AddDays(7);
            }

            // Nếu ngày chọn nhỏ hơn ngày bắt đầu gói -> Lấy ngày bắt đầu gói làm chuẩn
            // (Ví dụ: Gói bắt đầu 01/12, hôm nay 15/11 -> Phải đợi đến 01/12 mới đặt được)
            // (Giả sử bạn có biến ngayBatDauGoi, nếu không có thì bỏ qua dòng if này)
            // if (ngayMuonDat < this.ngayBatDauGoi) ngayMuonDat = ...

            // 3. CHUẨN BỊ VÒNG LẶP
            // Ngày hiện tại để chạy vòng lặp (Bao gồm cả giờ bắt đầu)
            DateTime ngayHienTai = ngayMuonDat.Date + gioBatDau;

            // Ngày kết thúc vòng lặp (23:59:59 của ngày hết hạn gói)
            DateTime ngayHetHanCuoiNgay = this.ngayHetHanGoi.Date.AddDays(1).AddSeconds(-1);

            int soBuoiThanhCong = 0;
            int soBuoiThatBai = 0;

            // 4. VÒNG LẶP ĐĂNG KÝ (LẶP LẠI HÀNG TUẦN)
            while (ngayHienTai <= ngayHetHanCuoiNgay)
            {
                DateTime startFull = ngayHienTai;
                DateTime endFull = ngayHienTai.Date + gioKetThuc;

                // A. Kiểm tra HLV có bận không
                bool isBan = lichBUS.CheckHLVBan(maHLV, startFull.Date, gioBatDau, gioKetThuc);

                if (!isBan)
                {
                    try
                    {
                        // B. Gọi BUS để Thêm Buổi (SQL sẽ tự trừ số buổi còn lại)
                        if (lichBUS.ThemBuoiTap(this.maDKPT, maHLV, startFull, endFull))
                        {
                            soBuoiThanhCong++;
                        }
                        else
                        {
                            // Nếu SQL trả về false (thường do hết số buổi trong gói) -> Dừng luôn
                            MessageBox.Show($"Gói tập đã hết số buổi! Dừng đặt lịch tại ngày {startFull:dd/MM/yyyy}.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lưu: " + ex.Message);
                        break;
                    }
                }
                else
                {
                    soBuoiThatBai++; // HLV bận, bỏ qua tuần này
                }

                // C. Nhảy sang tuần tiếp theo (+7 ngày)
                ngayHienTai = ngayHienTai.AddDays(7);
            }

            // 5. KẾT THÚC & THÔNG BÁO
            if (soBuoiThanhCong > 0)
            {
                string msg = $"Đã đặt thành công {soBuoiThanhCong} buổi vào thứ {cbo_NgayTrongTuan.Text} hàng tuần.";
                if (soBuoiThatBai > 0)
                    msg += $"\n(Có {soBuoiThatBai} buổi không đặt được do HLV bận).";

                MessageBox.Show(msg, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại lịch để thấy các buổi mới
                LoadCalendarHLV(dtp_NgayLich.Value);
            }
            else if (soBuoiThatBai > 0)
            {
                MessageBox.Show("Không đặt được buổi nào do HLV bận tất cả các tuần!", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Trường hợp này hiếm: Ngày bắt đầu > Ngày kết thúc gói
                MessageBox.Show("Không đặt được. Có thể gói tập đã hết hạn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Cbo_HuanLuyenVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_HuanLuyenVien.SelectedValue != null)
            {
                
                string maHLV = "";
                if (cbo_HuanLuyenVien.SelectedValue is DataRowView row)
                    maHLV = row["MaHLV"].ToString();
                else
                    maHLV = cbo_HuanLuyenVien.SelectedValue.ToString();

                LoadCalendarHLV(dtp_NgayLich.Value);
            }
        }

        public void LoadCalendarHLV(DateTime ngayTrongTuan)
        {
            if (cbo_HuanLuyenVien.SelectedValue == null)
            {
                ClearAllCells();
                return;
            }

            string maHLV = "";
            if (cbo_HuanLuyenVien.SelectedValue is DataRowView r)
                maHLV = r["MaHLV"].ToString();
            else
                maHLV = cbo_HuanLuyenVien.SelectedValue.ToString();

            DateTime ngayDauTuan = GetStartOfWeek(ngayTrongTuan);
            DateTime ngayCuoiTuan = ngayDauTuan.AddDays(6);

            UpdateHeaders(ngayDauTuan);
            ClearAllCells();

            DataTable dtLichBan = hlvBus.GetLichDayPT(maHLV, ngayDauTuan, ngayCuoiTuan);

            if (dtLichBan != null && dtLichBan.Rows.Count > 0)
            {
                foreach (DataRow row in dtLichBan.Rows)
                {
                    VeKhoiLichBan(row);
                }
            }
        }

        private void VeKhoiLichBan(DataRow row)
        {
            string tenKhach = row["ChiTiet"].ToString();
            
            string tieuDeGoc = tenKhach.Replace("Học viên: ", "").Replace("N'Học viên: ", "");

            int thu = Convert.ToInt32(row["ThuTrongTuan"]);

            
            TimeSpan gio = Convert.ToDateTime(row["GioBatDau"]).TimeOfDay;
            TimeSpan gioKetThuc = Convert.ToDateTime(row["GioKetThuc"]).TimeOfDay;

            string thoiGian = string.Format("{0:hh\\:mm} - {1:hh\\:mm}", gio, gioKetThuc);

            Panel pnlBlock = new Panel
            {
                // (Lưu ý: Width phải nhỏ hơn ô chứa nó)
                Width = 100, // Hoặc flpSangThu2.Width - 5
                Height = 80,
                Margin = new Padding(3),
                BackColor = Color.Salmon,
                BorderStyle = BorderStyle.FixedSingle
            };

            Label lblContent = new Label
            {
                Text = tieuDeGoc + "\n" + thoiGian,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font(Font, FontStyle.Bold)
            };

            ToolTip tt = new ToolTip();
            tt.SetToolTip(lblContent, tenKhach);

            pnlBlock.Controls.Add(lblContent);

            FlowLayoutPanel cell = GetCell(thu, gio);
            if (cell != null) cell.Controls.Add(pnlBlock);
        }

        private FlowLayoutPanel GetCell(int thuTrongTuan, TimeSpan gioBatDau)
        {
            string caHoc = "Toi";
            if (gioBatDau.Hours < 12) caHoc = "Sang";
            else if (gioBatDau.Hours < 18) caHoc = "Chieu";

            string tenThu = "CN";
            if (thuTrongTuan >= 2 && thuTrongTuan <= 7)
                tenThu = "Thu" + thuTrongTuan;

            string controlName = "flp" + caHoc + tenThu;

            
            if (tableLayoutPanel3.Controls.ContainsKey(controlName))
            {
                return (FlowLayoutPanel)tableLayoutPanel3.Controls[controlName];
            }
            return null;
        }

        private void ClearAllCells()
        {
            
            foreach (Control ctrl in tableLayoutPanel3.Controls)
            {
                if (ctrl is FlowLayoutPanel)
                {
                    ((FlowLayoutPanel)ctrl).Controls.Clear();
                }
            }
        }

        
        private void FrmDatLichHLV_Load(object sender, EventArgs e)
        {
            txt_HoTenHoiVien.Text = string.Empty;
            cbo_NgayTrongTuan.Items.AddRange(new string[] {
                "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ Nhật"
            });
            cbo_NgayTrongTuan.SelectedIndex = 0;

            DataTable dtHLV = hlvBus.GetOnlyPT();
            cbo_HuanLuyenVien.DisplayMember = "TenHLV";
            cbo_HuanLuyenVien.ValueMember = "MaHLV";
            cbo_HuanLuyenVien.DataSource = dtHLV;

            currentWeekStart = GetStartOfWeek(DateTime.Now);

            // Sửa: Chỉ gọi SelectedIndex = 0, bỏ dòng gọi LoadCalendar thừa
            if (cbo_HuanLuyenVien.Items.Count > 0)
            {
                cbo_HuanLuyenVien.SelectedIndex = 0;
            }
            else
            {
                cbo_HuanLuyenVien.SelectedIndex = -1;
            }


        }

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
    }
}