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
    public partial class frmChiTietMember : Form
    {
        public frmChiTietMember()
        {
            InitializeComponent();
            this.btn_DangKyPT.Click += Btn_DangKyPT_Click;
            this.btn_DangKyLop.Click += Btn_DangKyLop_Click;

        }

        private void Btn_DangKyLop_Click(object sender, EventArgs e)
        {
            frmDangKyLop frmDangKyLop = new frmDangKyLop();
            frmDangKyLop.ShowDialog();
        }

        private void Btn_DangKyPT_Click(object sender, EventArgs e)
        {
           frmDangKyPT frmDangKyHLV = new frmDangKyPT();
            frmDangKyHLV.ShowDialog();

        }
    }
}
