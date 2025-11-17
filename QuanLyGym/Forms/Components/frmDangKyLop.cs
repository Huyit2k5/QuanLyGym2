using QuanLyGym.BUS;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyGym.Forms
{
    public partial class frmDangKyLop : Form
    {
        private string maKhachHang_NhanDuoc;
        private KhachHangBUS khBus = new KhachHangBUS();
        private LopBUS lopBus = new LopBUS();

        // === THÊM BIẾN NÀY ===
        private DateTime ngayBatDau_DaTinh; // Biến lưu ngày bắt đầu

        public frmDangKyLop(string maKH)
        {
            InitializeComponent();
            this.maKhachHang_NhanDuoc = maKH;
            this.CenterToParent();

            this.Load += FrmDangKyLop_Load;
            this.btn_DangKy.Click += BtnDangKy_Click;
        }

        private void FrmDangKyLop_Load(object sender, EventArgs e)
        {
            // 1. Tải tên
            DataRow khRow = khBus.GetKH_ById(maKhachHang_NhanDuoc);
            txt_TenKH.Text = khRow["TenKH"].ToString();
            txt_TenKH.ReadOnly = true;

            // 2. Tải Lớp
            cbo_Lop.DataSource = lopBus.GetAllLop();
            cbo_Lop.DisplayMember = "TenLopHienThi";
            cbo_Lop.ValueMember = "MaLop";

            // 3. Tải Thời hạn (Bạn phải thêm ComboBox 'cbo_ThoiHan' vào Form [Design])
            cbo_ThoiHan.Items.Add(new { Text = "1 Tháng", Value = 1 });
            cbo_ThoiHan.Items.Add(new { Text = "3 Tháng", Value = 3 });
            cbo_ThoiHan.Items.Add(new { Text = "6 Tháng", Value = 6 });
            cbo_ThoiHan.DisplayMember = "Text";
            cbo_ThoiHan.ValueMember = "Value";
            cbo_ThoiHan.SelectedIndex = 0;

            // 4. Set ngày bắt đầu (SỬA LẠI)
            this.ngayBatDau_DaTinh = DateTime.Today; // 1. Lưu vào biến
            txt_NgayBatDau.Text = this.ngayBatDau_DaTinh.ToString("dd/MM/yyyy"); // 2. Hiển thị
            txt_NgayBatDau.ReadOnly = true; // Khóa lại
        }

        private void BtnDangKy_Click(object sender, EventArgs e)
        {
            if (cbo_Lop.SelectedValue == null || cbo_ThoiHan.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn đầy đủ thông tin.");
                return;
            }

            // 1. Thu thập dữ liệu
            string maLop = cbo_Lop.SelectedValue.ToString();

            
            DateTime ngayBatDau = this.ngayBatDau_DaTinh; 

            int soThang = (int)(cbo_ThoiHan.SelectedItem as dynamic).Value;
            string maNV = "NV01"; 

            // 2. Xác nhận
            string tenLop = ((DataRowView)cbo_Lop.SelectedItem)["TenLopHienThi"].ToString();
            string msg = string.Format("Xác nhận đăng ký '{0}' ({1} tháng) cho hội viên này?", tenLop, soThang);
            DialogResult dr = MessageBox.Show(msg, "Xác nhận", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)
                return;

            
            try
            {
                bool thanhCong = lopBus.DangKyLop(maKhachHang_NhanDuoc, maNV, maLop, ngayBatDau, soThang);

                if (thanhCong)
                {
                    MessageBox.Show("Đăng ký lớp thành công!");
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