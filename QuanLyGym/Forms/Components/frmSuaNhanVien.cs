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

namespace QuanLyGym.Forms.Components
{
    public partial class frmSuaNhanVien : Form
    {
        NhanVien nv = new NhanVien();
        NhanVienBUS nvBus = new NhanVienBUS();
        private string _maNV;
        public frmSuaNhanVien(string maNV)
        {
            InitializeComponent();
            _maNV = maNV;

            this.Load += SuaNhanVien_Load;
            this.btn_Luu.Click += Btn_Luu_Click;
        }

        private void Btn_Luu_Click(object sender, EventArgs e)
        {
            nv.MaNV = txt_MaNV.Text;
            nv.TenNV = txt_TenNV.Text;
            nv.GioiTinh = cbo_GioiTinh.Text;
            nv.ChucVu = cbo_ChucVu.Text;
            nv.Sdt = txt_SDT.Text;

            if (nvBus.SuaNV(nv))
            {
                MessageBox.Show("Lưu nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lưu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
            }
        }

        private void SuaNhanVien_Load(object sender, EventArgs e)
        {
            txt_MaNV.Enabled = false;
            txt_MaNV.Text = _maNV;
            cbo_GioiTinh.Items.Add("Nam");
            cbo_GioiTinh.Items.Add("Nữ");

            cbo_ChucVu.Items.Add("Admin");
            cbo_ChucVu.Items.Add("NhanVien");

            string maNV = txt_MaNV.Text;

            DataRow row = nvBus.GetNV_ById(maNV);

            if (row != null)
            {
                txt_TenNV.Text = row["TenNV"].ToString();
                cbo_GioiTinh.Text = row["GioiTinh"].ToString();
                cbo_ChucVu.Text = row["ChucVu"].ToString();
                txt_SDT.Text = row["SDT"].ToString();
            }
        }
    }
}
