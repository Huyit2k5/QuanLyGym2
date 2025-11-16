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
using QuanLyGym.BUS;
using QuanLyGym.Modals;

namespace QuanLyGym.Forms
{
    public partial class frmGoiTap : Form
    {
        GoiTapBUS goiTapBus = new GoiTapBUS();
        // Nhập hàm SendMessage từ thư viện user32.dll của Windows
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SendMessage(IntPtr hWnd, int msg, int wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);
        
        // Đây là hằng số để ra lệnh cho TextBox "Hãy set placeholder"
        private const int EM_SETCUEBANNER = 0x1501;
        private BindingSource bsGoiTap = new BindingSource();
        public frmGoiTap()
        {
            InitializeComponent();
            this.Load += FrmGoiTap_Load;
            this.txt_SearchGoiTap.HandleCreated += Txt_SearchGoiTap_HandleCreated;
            this.txt_SearchGoiTap.KeyDown += Txt_SearchGoiTap_KeyDown;
        }

        private void Txt_SearchGoiTap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Lấy nội dung cuối cùng trong TextBox
                string query = txt_SearchGoiTap.Text.Trim();
                query = query.Replace("'", "''"); // Xử lý nếu query có dấu '

                try
                {
                    //Áp dụng bộ lọc
                    // Nếu query rỗng, ta "xóa" bộ lọc (hiện lại tất cả)
                    if (string.IsNullOrEmpty(query))
                    {
                        bsGoiTap.Filter = null; // Xóa bộ lọc
                    }
                    else
                    {
                        
                        bsGoiTap.Filter = string.Format("TenGoi LIKE '%{0}%' OR MaGoi LIKE '%{0}%'", query);
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

        private void Txt_SearchGoiTap_HandleCreated(object sender, EventArgs e)
        {
            SendMessage(txt_SearchGoiTap.Handle, EM_SETCUEBANNER, 1, "Tên gói cần tìm kiếm...");
        }

        private void FrmGoiTap_Load(object sender, EventArgs e)
        {
            // 1. Tải dữ liệu từ BUS VÀO BINDINGSOURCE
            bsGoiTap.DataSource = goiTapBus.GetAllGoiTap();

            // 2. Gán DataGridView VÀO BINDINGSOURCE
            dgv_GoiTap.DataSource = bsGoiTap;

            // 3. (TÙY CHỌN) Thêm AutoComplete (Gợi ý xổ xuống)
            try
            {
                // 3.1. Tạo bộ sưu tập gợi ý
                AutoCompleteStringCollection suggestions = new AutoCompleteStringCollection();

                // 3.2. Lấy dữ liệu từ BindingSource
                DataTable dt = (DataTable)bsGoiTap.DataSource;

                if (dt != null)
                {
                    // 3.3. Lặp qua dữ liệu
                    foreach (DataRow row in dt.Rows)
                    {
                        // Thêm Tên Gói vào gợi ý
                        suggestions.Add(row["TenGoi"].ToString());
                        // Thêm Mã Gói vào gợi ý
                        suggestions.Add(row["MaGoi"].ToString());
                    }
                }

                // 3.4. Nạp gợi ý vào TextBox
                txt_SearchGoiTap.AutoCompleteCustomSource = suggestions;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nạp gợi ý tìm kiếm: " + ex.Message);
            }
        }
    }
}
