using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using QuanLyGym.Modals;
using QuanLyGym.BUS;

namespace QuanLyGym.Forms
{
    public partial class frmLop : Form
    {
        LopBUS lopBus = new LopBUS();
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        // Đây là hằng số để ra lệnh cho TextBox "Hãy set placeholder"
        private const int EM_SETCUEBANNER = 0x1501;
        private BindingSource bsLop = new BindingSource();
        
        public frmLop()
        {
            InitializeComponent();
            this.btn_ThemLop.Click += Btn_ThemLop_Click;
           
            this.txt_SearchLop.HandleCreated += Txt_SearchLop_HandleCreated;
            this.txt_SearchLop.KeyDown += Txt_SearchLop_KeyDown;
            this.dgv_DanhSachCacLop.SelectionChanged += Dgv_DanhSachCacLop_SelectionChanged;

            this.Load += FrmLop_Load;

        }

        private void Btn_ThemLop_Click(object sender, EventArgs e)
        {
            dgv_DanhSachCacLop.ReadOnly = false;
        }

        private void Dgv_DanhSachCacLop_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DanhSachCacLop.CurrentRow != null)
            {
                
                string maLop = dgv_DanhSachCacLop.CurrentRow.Cells["Col_MaLop"].Value.ToString();

                
                dgv_HoiVienCuaLop.DataSource = lopBus.GetHoiVienByLop(maLop);
            }
            else
            {
                
                dgv_HoiVienCuaLop.DataSource = null;
            }
        }

        private void FrmLop_Load(object sender, EventArgs e)
        {
            dgv_DanhSachCacLop.ReadOnly = true;
            // 1. Tải dữ liệu từ BUS VÀO BINDINGSOURCE
            bsLop.DataSource = lopBus.GetAllLopForManage();


            // 2. Gán DataGridView VÀO BINDINGSOURCE
            dgv_DanhSachCacLop.DataSource = bsLop;

            // 3. (TÙY CHỌN) Thêm AutoComplete (Gợi ý xổ xuống)
            try
            {
                // 3.1. Tạo bộ sưu tập gợi ý
                AutoCompleteStringCollection suggestions = new AutoCompleteStringCollection();

                // 3.2. Lấy dữ liệu từ BindingSource
                DataTable dt = (DataTable)bsLop.DataSource;

                if (dt != null)
                {
                    // 3.3. Lặp qua dữ liệu
                    foreach (DataRow row in dt.Rows)
                    {
                        // Thêm Tên Gói vào gợi ý
                        suggestions.Add(row["TenLop"].ToString());
                        // Thêm Mã Gói vào gợi ý
                        suggestions.Add(row["MaLop"].ToString());

                        suggestions.Add(row["MaHLV"].ToString());
                    }
                }

                // 3.4. Nạp gợi ý vào TextBox
                txt_SearchLop.AutoCompleteCustomSource = suggestions;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nạp gợi ý tìm kiếm: " + ex.Message);
            }
        }

        private void Txt_SearchLop_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Lấy nội dung cuối cùng trong TextBox
                string query = txt_SearchLop.Text.Trim();
                query = query.Replace("'", "''"); // Xử lý nếu query có dấu '

                try
                {
                    //Áp dụng bộ lọc
                    // Nếu query rỗng, ta "xóa" bộ lọc (hiện lại tất cả)
                    if (string.IsNullOrEmpty(query))
                    {
                        bsLop.Filter = null; // Xóa bộ lọc
                    }
                    else
                    {

                        bsLop.Filter = string.Format("TenLop LIKE '%{0}%' OR MaLop LIKE '%{0}%' OR MaHLV LIKE '%{0}%'", query);
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

        private void Txt_SearchLop_HandleCreated(object sender, EventArgs e)
        {
            SendMessage(txt_SearchLop.Handle, EM_SETCUEBANNER, 1, "Mã lớp/Tên lớp/Mã hlv cần tìm kiếm...");
        }

        

       
    }
}
