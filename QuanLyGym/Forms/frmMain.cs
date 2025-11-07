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
        }
        // Hàm chung để mở 1 form con (childForm) vào 1 panel
        private void OpenChildForm(Form childForm)
        {
           
            pnl_Main.Controls.Clear();

            
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            
            pnl_Main.Controls.Add(childForm);
            childForm.Show();
        }
        private void Btn_ShowMember_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang());

        }
    }
}
