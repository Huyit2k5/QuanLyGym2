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
    public partial class frmAddTrainner : Form
    {
        public frmAddTrainner()
        {
            InitializeComponent();
            this.ptb_HLV.Click += Ptb_HLV_Click;

        }

        private void Ptb_HLV_Click(object sender, EventArgs e)
        {
           
            // 1. TẠO ĐỐI TƯỢNG OPENFILEDIALOG
           
            OpenFileDialog dialog = new OpenFileDialog();

            // 2. THIẾT LẬP BỘ LỌC (FILTER)
            // Chỉ cho phép người dùng chọn các file ảnh
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            dialog.Title = "Hãy chọn một hình ảnh";


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // 4. LẤY ĐƯỜNG DẪN FILE ĐÃ CHỌN
                    string selectedImagePath = dialog.FileName;

                    // 5. TẢI HÌNH ẢNH VÀO PICTUREBOX
                    // (Nên dùng new Bitmap() để tránh lỗi khóa file)
                    ptb_HLV.Image = new Bitmap(selectedImagePath);

                    // (Tùy chọn) Chỉnh chế độ hiển thị cho vừa khung
                    ptb_HLV.SizeMode = PictureBoxSizeMode.Zoom;
                    ptb_HLV.BackgroundImage = null;
                }
                catch (Exception ex)
                {
                    // Xử lý nếu file không phải là ảnh hợp lệ
                    MessageBox.Show("Lỗi: Không thể tải hình ảnh. " + ex.Message);
                }
            
        }
    }
    }
}
