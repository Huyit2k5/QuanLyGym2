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
    public partial class frmLop : Form
    {
        public frmLop()
        {
            InitializeComponent();
            this.btn_AddMember.Click += Btn_AddMember_Click;
        }

        private void Btn_AddMember_Click(object sender, EventArgs e)
        {
            frmDangKyLop dkl = new frmDangKyLop();
            dkl.ShowDialog();
        }

       
    }
}
