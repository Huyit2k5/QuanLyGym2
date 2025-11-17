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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            CenterToScreen();
            InitializeComponent();
            this.btn_ShowMember.Click += Btn_ShowMember_Click;
            this.btn_GoiTap.Click += Btn_GoiTap_Click;
            this.btn_HuanLuyenVien.Click += Btn_HuanLuyenVien_Click;
            this.btn_LopTap.Click += Btn_LopTap_Click;
            this.btn_ThietBi.Click += Btn_ThietBi_Click;
        }

        private void Btn_ThietBi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThietBi());
        }

        private void Btn_LopTap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLop());
        }

        private void Btn_HuanLuyenVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHuanLuyenVien());
        }

        private void Btn_GoiTap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmGoiTap());
        }

        // Hàm chung để mở 1 form con (childForm) vào 1 panel
        public void OpenChildForm(Form childForm)
        {
           
            pnl_Main.Controls.Clear();

            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            
            pnl_Main.Controls.Add(childForm);
            childForm.Show();
        }
        public void Btn_ShowMember_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());

        }
    }
}
