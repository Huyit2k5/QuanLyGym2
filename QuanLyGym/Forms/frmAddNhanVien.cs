using QuanLyGym.BUS;
using QuanLyGym.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGym.Forms
{
    public partial class frmAddNhanVien : Form
    {
        NhanVienBUS nvBus = new NhanVienBUS();
        NhanVien nv = new NhanVien();
        public frmAddNhanVien()
        {
            InitializeComponent();
            this.Load += FrmAddNhanVien_Load;
            this.btn_Luu.Click += Btn_Luu_Click;
        }

        private void Btn_Luu_Click(object sender, EventArgs e)
        {
            nv.MaNV = txt_MaNV.Text;
            nv.TenNV = txt_TenNV.Text;
            nv.GioiTinh = cbo_GioiTinh.Text;
            nv.ChucVu = cbo_ChucVu.Text;
            nv.Sdt = txt_SDT.Text;
            if (nvBus.ThemNV(nv)) {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmAddNhanVien_Load(object sender, EventArgs e)
        {
            txt_MaNV.Enabled = false;
            txt_MaNV.Text = nvBus.TuDongSinhMaNV();
            cbo_GioiTinh.Items.Add("Nam");
            cbo_GioiTinh.Items.Add("Nữ");

            cbo_ChucVu.Items.Add("Admin");
            cbo_ChucVu.Items.Add("NhanVien");
        }
    }
}
