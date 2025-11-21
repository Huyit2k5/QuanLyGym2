using QuanLyGym.BUS;
using QuanLyGym.Forms.Components;
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
    public partial class frmNhanVien : Form
    {
        NhanVienBUS nvBus = new NhanVienBUS();
        public frmNhanVien()
        {
            InitializeComponent();
            this.Load += FrmNhanVien_Load;
            this.btn_Them.Click += Btn_Them_Click;
            this.btn_Sua.Click += Btn_Sua_Click;
            this.btn_Xoa.Click += Btn_Xoa_Click;
        }

        private void Btn_Xoa_Click(object sender, EventArgs e)
        {
            string maNV = dgv_NhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (nvBus.XoaNV(maNV))
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_NhanVien.DataSource = nvBus.LoadNV();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Btn_Sua_Click(object sender, EventArgs e)
        {
            string maNV = dgv_NhanVien.CurrentRow.Cells["MaNV"].Value.ToString();
            string tenNV = dgv_NhanVien.CurrentRow.Cells["TenNV"].Value.ToString();
            string gioiTinh = dgv_NhanVien.CurrentRow.Cells["GioiTinh"].Value.ToString();
            string sdt = dgv_NhanVien.CurrentRow.Cells["SDT"].Value.ToString();
            string chucVu = dgv_NhanVien.CurrentRow.Cells["ChucVu"].Value.ToString();

            frmSuaNhanVien suaNhanVien = new frmSuaNhanVien(maNV);
            suaNhanVien.ShowDialog();
            dgv_NhanVien.DataSource = nvBus.LoadNV();

        }

        private void Btn_Them_Click(object sender, EventArgs e)
        {
            frmAddNhanVien addNVForm = new frmAddNhanVien();
            addNVForm.ShowDialog();
            dgv_NhanVien.DataSource = nvBus.LoadNV();

        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            dgv_NhanVien.DataSource = nvBus.LoadNV();

        }
    }
}
