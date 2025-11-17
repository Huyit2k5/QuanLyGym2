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

namespace QuanLyGym.Forms
{
    public partial class frmDangKyPT : Form
    {
        private string maKhachHang_NhanDuoc;
        private DateTime ngayBatDau_DaTinh; // Biến lưu ngày bắt đầu

        // Khai báo BUS
        private HuanLuyenVienBUS hlvBus = new HuanLuyenVienBUS();
        private KhachHangBUS khBus = new KhachHangBUS();

        private DataRowView selectedGoiPT;
        public frmDangKyPT(string maKH)
        {
            InitializeComponent();
            this.maKhachHang_NhanDuoc = maKH;
            this.CenterToParent();

            this.Load += FrmDangKyPT_Load; ;
            this.btn_DangKy.Click += Btn_DangKy_Click; ;
            this.cbo_GoiPT.SelectedIndexChanged += TinhToanChiTietGoi; 
            
        }

        

        private void FrmDangKyPT_Load(object sender, EventArgs e)
        {
            // 1. Tải tên hội viên
            DataRow khRow = khBus.GetKH_ById(maKhachHang_NhanDuoc);
            if (khRow != null)
            {
                txt_TenHoiVien.Text = khRow["TenKH"].ToString();
            }
            txt_TenHoiVien.ReadOnly = true;

            // 2. Tải danh sách Gói PT vào ComboBox
            cbo_GoiPT.DataSource = hlvBus.GetAllGoiPT() ;
            cbo_GoiPT.DisplayMember = "TenGoiPT";
            cbo_GoiPT.ValueMember = "MaGoiPT";

            // 3. CÀI ĐẶT NGÀY BẮT ĐẦU (MẶC ĐỊNH LÀ HÔM NAY)
            this.ngayBatDau_DaTinh = DateTime.Today;

            // Hiển thị lên TextBox
            txt_NgayBatDauGoiPT.Text = this.ngayBatDau_DaTinh.ToString("dd/MM/yyyy");
            txt_NgayBatDauGoiPT.ReadOnly = true; // Khóa không cho sửa

            // 4. Tính toán lần đầu
            TinhToanChiTietGoi(null, null);



        }

        private void TinhToanChiTietGoi(object sender, EventArgs e)
        {
            if (cbo_GoiPT.SelectedItem == null) return;

            selectedGoiPT = (DataRowView)cbo_GoiPT.SelectedItem;

            
            int soBuoi = Convert.ToInt32(selectedGoiPT["SoBuoi"]);

           
            txt_SoBuoiGoiPt.Text = soBuoi.ToString() + " buổi";

            // 2. TÍNH HẠN SỬ DỤNG (LOGIC MỚI)
            DateTime ngayBatDau = this.ngayBatDau_DaTinh;
            DateTime ngayKetThuc;

            // Cách A: Quy định lỏng (Mỗi 10 buổi cho 2 tháng)
            // Ví dụ: 10 buổi -> 2 tháng, 30 buổi -> 6 tháng
            int soThang = (int)Math.Ceiling(soBuoi / 10.0) * 2;
            ngayKetThuc = ngayBatDau.AddMonths(soThang);

            // Cách B: Nếu bạn muốn "Vô hạn", hãy dùng dòng này:
            // ngayKetThuc = ngayBatDau.AddYears(1); // Cho hạn 1 năm

            txt_NgayKetThucGoi.Text = ngayKetThuc.ToString("dd/MM/yyyy");


        }

        private void Btn_DangKy_Click(object sender, EventArgs e)
        {
            if (cbo_GoiPT.SelectedValue == null) return;

            string maGoiPT = cbo_GoiPT.SelectedValue.ToString();
            DateTime ngayBatDau = this.ngayBatDau_DaTinh;

            string tenGoi = cbo_GoiPT.Text;
            string msg = string.Format("Xác nhận đăng ký '{0}' cho hội viên này?", tenGoi);

            if (MessageBox.Show(msg, "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            try
            {
                // Gọi hàm thêm thẻ đơn giản
                bool thanhCong = hlvBus.DangKyGoiPT(maKhachHang_NhanDuoc, maGoiPT, ngayBatDau);

                if (thanhCong)
                {
                    MessageBox.Show("Đăng ký thành công!");
                    this.Close(); // Đóng form
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

       
       
    }
    
}
