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
    public partial class frmNhanVien : Form
    {
        NhanVienBUS nvBus = new NhanVienBUS();
        public frmNhanVien()
        {
            InitializeComponent();
            this.Load += FrmNhanVien_Load;
            this.btn_Them.Click += Btn_Them_Click;
        }

        private void Btn_Them_Click(object sender, EventArgs e)
        {
            frmAddNhanVien addNVForm = new frmAddNhanVien();
            addNVForm.ShowDialog();
        }

        private void FrmNhanVien_Load(object sender, EventArgs e)
        {
            dgv_NhanVien.DataSource = nvBus.LoadNV();

        }
    }
}
