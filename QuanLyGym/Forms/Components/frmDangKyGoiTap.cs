using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGym.BUS;
using QuanLyGym.Modals;

namespace QuanLyGym.Forms.Components
{
    public partial class frmDangKyGoiTap : Form
    {
       
        private string maKhachHang_NhanDuoc;
        private DateTime ngayBatDau_DaTinh; 

        
        private KhachHangBUS khBus = new KhachHangBUS();
        private GoiTapBUS goiTapBus = new GoiTapBUS();
        

        // Biến lưu gói tập đang được chọn
        private DataRowView selectedGoiTap;

       
        public frmDangKyGoiTap(string maKH)
        {
            InitializeComponent();
            this.maKhachHang_NhanDuoc = maKH;
            this.CenterToParent(); 

            // Đăng ký sự kiện
            this.Load += FrmDangKyGoiTap_Load;
            this.btn_XacNhan.Click += BtnXacNhan_Click;
            this.cbo_Goi.SelectedIndexChanged += TinhToanGoiMoi;
        }

       
        private void FrmDangKyGoiTap_Load(object sender, EventArgs e)
        {
            // Tải tên hội viên
            DataRow khRow = khBus.GetKH_ById(maKhachHang_NhanDuoc);
            txt_HoVaTen.Text = khRow["TenKH"].ToString();
            txt_HoVaTen.ReadOnly = true;
            txt_TinhTrang.ReadOnly = true;
            txt_NgayBatDau.ReadOnly = true;

            // Tải Gói tập vào ComboBox
            cbo_Goi.DataSource = goiTapBus.GetAllGoiTap();
            cbo_Goi.DisplayMember = "TenGoi";
            cbo_Goi.ValueMember = "MaGoi";

            // (Đăng ký mới / Gia hạn)
            DataRow theCu = goiTapBus.GetActiveTheThanhVien(maKhachHang_NhanDuoc);

            if (theCu == null)
            {
                // TRƯỜNG HỢP 1: ĐĂNG KÝ MỚI
                txt_TinhTrang.Text = "Đăng ký mới"; // Sửa: Dùng txt_TinhTrang
                txt_TinhTrang.ForeColor = Color.Green;

                // Lưu ngày vào biến
                this.ngayBatDau_DaTinh = DateTime.Today;
                // Hiển thị ngày đã format
                txt_NgayBatDau.Text = this.ngayBatDau_DaTinh.ToString("dd/MM/yyyy");

                btn_XacNhan.Text = "Xác nhận Đăng ký";
            }
            else
            {
                // TRƯỜNG HỢP 2: GIA HẠN
                DateTime ngayHetHanCu = Convert.ToDateTime(theCu["NgayHetHan"]);
                // Sửa: Dùng txt_TinhTrang
                txt_TinhTrang.Text = "Gia hạn (Hết hạn: " + ngayHetHanCu.ToString("dd/MM/yyyy") + ")";
                txt_TinhTrang.ForeColor = Color.Blue;

                // Lưu ngày vào biến
                this.ngayBatDau_DaTinh = ngayHetHanCu.AddDays(1);
                // Hiển thị ngày đã format
                txt_NgayBatDau.Text = this.ngayBatDau_DaTinh.ToString("dd/MM/yyyy");

                btn_XacNhan.Text = "Xác nhận Gia hạn";
            }

            // 4. Tải các label tính toán (nếu có)
            //TinhToanGoiMoi(null, null);
        }

        // === 4. HÀM TÍNH TOÁN (ĐÃ SỬA LỖI) ===
        private void TinhToanGoiMoi(object sender, EventArgs e)
        {
            if (cbo_Goi.SelectedItem == null) return;

            selectedGoiTap = (DataRowView)cbo_Goi.SelectedItem;

            // hiển thị giá và ngày hết hạn
            

            // decimal gia = Convert.ToDecimal(selectedGoiTap["Gia"]);
            // int thoiHanNgay = Convert.ToInt32(selectedGoiTap["ThoiHan"]);
            // DateTime ngayBatDau = this.ngayBatDau_DaTinh; 
            // DateTime ngayKetThuc = ngayBatDau.AddDays(thoiHanNgay - 1);
            // lblThanhTien.Text = gia.ToString("N0") + " VND";
            // lblNgayHetHanMoi.Text = ngayKetThuc.ToString("dd/MM/yyyy");
        }

        // === 5. HÀM LƯU  ===
        private void BtnXacNhan_Click(object sender, EventArgs e)
        {
            if (cbo_Goi.SelectedValue == null) return;

            string maGoi = cbo_Goi.SelectedValue.ToString();
            DateTime ngayBatDau = this.ngayBatDau_DaTinh;
            string maNV = "NV01"; 

            string tenGoi = selectedGoiTap["TenGoi"].ToString();
            string msg = string.Format("Xác nhận đăng ký '{0}' cho hội viên này?", tenGoi);
            DialogResult dr = MessageBox.Show(msg, "Xác nhận", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
                return;

            try
            {
               
                bool thanhCong = goiTapBus.DangKyGoiMoi(maKhachHang_NhanDuoc, maNV, maGoi, ngayBatDau);

                if (thanhCong)
                {
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close(); // Đóng form
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại. (Lỗi từ CSDL)");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nghiêm trọng: " + ex.Message);
            }
        }
    }
}