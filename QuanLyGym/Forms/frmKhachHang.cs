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
using System.Runtime.InteropServices;
using QuanLyGym.Forms.Components;

namespace QuanLyGym.Forms
{
    public partial class frmKhachHang : Form
    {
        // Nhập hàm SendMessage từ thư viện user32.dll của Windows
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        // Đây là hằng số để ra lệnh cho TextBox "Hãy set placeholder"
        private const int EM_SETCUEBANNER = 0x1501;

        private BindingSource bsKhachHang = new BindingSource();
        KhachHangBUS khBus = new KhachHangBUS();
        public frmKhachHang()
        {
            InitializeComponent();
            this.CenterToParent();
            this.txt_SearchMember.HandleCreated += Txt_SearchMember_HandleCreated;
            this.txt_SearchMember.KeyDown += Txt_SearchMember_KeyDown;

            this.tlr_Function.Click += Btn_AddMember_Click;
            this.dgv_Members.CellMouseClick += Dgv_Members_CellMouseClick;

            //this.suaToolStripMenuItem.Click += SuaToolStripMenuItem_Click;
            this.xoaToolStripMenuItem.Click += XoaToolStripMenuItem_Click;
            this.ChiTietToolStripMenuItem.Click += ChiTietToolStripMenuItem_Click;

            this.Load += FrmKhachHang_Load;
           
        }

        private void Txt_SearchMember_KeyDown(object sender, KeyEventArgs e)
        { 
            //Kiểm tra xem phím được nhấn CÓ PHẢI LÀ phím ENTER không
            if (e.KeyCode == Keys.Enter)
            {
                //Lấy nội dung cuối cùng trong TextBox
                string query = txt_SearchMember.Text.Trim();
                query = query.Replace("'", "''"); // Xử lý nếu query có dấu '

                try
                {
                    //Áp dụng bộ lọc
                    // Nếu query rỗng, ta "xóa" bộ lọc (hiện lại tất cả)
                    if (string.IsNullOrEmpty(query))
                    {
                        bsKhachHang.Filter = null; // Xóa bộ lọc
                    }
                    else
                    {
                        // Áp dụng bộ lọc LIKE cho cả Tên và SĐT
                        bsKhachHang.Filter = string.Format("TenKH LIKE '%{0}%' OR SDT LIKE '%{0}%'", query);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi filter: " + ex.Message);
                }

                //Ngăn tiếng "ding" của Windows khi nhấn Enter
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
        

        private void Txt_SearchMember_HandleCreated(object sender, EventArgs e)
        {
            // Hiện thị placeholder cho search
            SendMessage(txt_SearchMember.Handle, EM_SETCUEBANNER, 1, "Nhập số điện thoại cần tìm kiếm...");
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

            try
            {
                // Tạo một bộ sưu tập mới để chứa gợi ý
                AutoCompleteStringCollection suggestions = new AutoCompleteStringCollection();

                //Lấy dữ liệu từ BindingSource (mà LoadKhachHang() vừa nạp)
               
                DataTable dt = (DataTable)bsKhachHang.DataSource;

                //Lặp qua từng dòng dữ liệu để nạp gợi ý
                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        // Nạp TÊN khách hàng vào danh sách gợi ý
                        suggestions.Add(row["TenKH"].ToString());

                        // Nạp SĐT khách hàng vào danh sách gợi ý
                        suggestions.Add(row["SDT"].ToString());
                    }
                }

                //Gán bộ sưu tập gợi ý này làm "Nguồn" cho TextBox
                txt_SearchMember.AutoCompleteCustomSource = suggestions;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nạp gợi ý tìm kiếm: " + ex.Message);
            }
        }

        private void ChiTietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string maKH = dgv_Members.CurrentRow.Cells["Col_MaHoiVien"].Value?.ToString();
            

            if (dgv_Members.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một hội viên.");
                return;
            }
            frmChiTietMember frmChiTietMember = new frmChiTietMember(maKH);
            frmChiTietMember.Show();




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

        //private void SuaToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    frmAddMember frmAddMember = new frmAddMember(bsKhachHang);

        //    if (dgv_Members.SelectedRows.Count > 0)
        //    {
        //        // Lấy ID hoặc dữ liệu từ dòng đã chọn
        //        string id = dgv_Members.SelectedRows[0].Cells["ID"].Value.ToString();
        //        MessageBox.Show($"Bạn chọn XÓA dòng có ID: {id}");
        //    }
        //    frmAddMember.FormClosed += (s, args) => LoadKhachHang(); // reload khi đóng
        //    frmAddMember.Show();
        //}

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
