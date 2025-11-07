using QuanLyGym.BUS;
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
    public partial class frmKhachHang : Form
    {
        private BindingSource bsKhachHang = new BindingSource();
        KhachHangBUS khBus = new KhachHangBUS();
        public frmKhachHang()
        {
            InitializeComponent();
            this.CenterToParent();
            this.btn_AddMember.Click += Btn_AddMember_Click;
            this.dgv_Members.CellMouseClick += Dgv_Members_CellMouseClick;
            this.suaToolStripMenuItem.Click += SuaToolStripMenuItem_Click;
            this.xoaToolStripMenuItem.Click += XoaToolStripMenuItem_Click;
            this.ChiTietToolStripMenuItem.Click += ChiTietToolStripMenuItem_Click;
            this.Load += FrmKhachHang_Load;
        }

        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            LoadKhachHang();
        }

        public void LoadKhachHang()
        {
            KhachHangBUS khBus = new KhachHangBUS();
            bsKhachHang.DataSource = khBus.GetAllKH();
            dgv_Members.DataSource = bsKhachHang;
        }

        private void ChiTietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMember frmAddMember = new frmAddMember(true);
            frmAddMember.Show();
        }

        private void XoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
                // Lấy ID hoặc dữ liệu từ dòng đã chọn
                string id = dgv_Members.CurrentRow.Cells["Col_MaHoiVien"].Value.ToString();
                if (khBus.XoaKH(id))
                {
                    MessageBox.Show($"XÓA dòng có ID: {id} thành công!");
                }
                else
                {
                    MessageBox.Show($"XÓA dòng có ID: {id} thất bại!");
                }


            
        }

        private void SuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMember frmAddMember = new frmAddMember(bsKhachHang);
            
            //if (dgv_Members.SelectedRows.Count > 0)
            //{
            //    // Lấy ID hoặc dữ liệu từ dòng đã chọn
            //    string id = dgv_Members.SelectedRows[0].Cells["ID"].Value.ToString();
            //        MessageBox.Show($"Bạn chọn XÓA dòng có ID: {id}");
            //}
            frmAddMember.FormClosed += (s, args) => LoadKhachHang(); // reload khi đóng
            frmAddMember.Show();
        }

        private void Dgv_Members_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                // Chọn dòng vừa được click chuột phải
                dgv_Members.ClearSelection(); // Xóa lựa chọn cũ (nếu có)
                dgv_Members.Rows[e.RowIndex].Selected = true;

                // (Tùy chọn) Đặt dòng này làm dòng hiện tại (CurrentRow)
                // Điều này rất hữu ích nếu bạn muốn lấy dữ liệu từ CurrentRow
                dgv_Members.CurrentCell = dgv_Members.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }


        }

        private void Btn_AddMember_Click(object sender, EventArgs e)
        {
            frmAddMember frmAddMember = new frmAddMember();
            frmAddMember.Show();
        }
    }
}
