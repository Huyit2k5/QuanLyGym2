using QuanLyGym.BUS;
using QuanLyGym.Modals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyGym.Forms
{
    public partial class frmAddMember : Form
    {
       
       
        KhachHangBUS khBus = new KhachHangBUS();
        public frmAddMember()
        {
            InitializeComponent();
            this.CenterToParent();
            this.pic_PictureMember.Click += Pic_PictureMember_Click;
            this.txt_MaHoiVien.Enabled = false;
           
          this.Load += FrmAddMember_Load;
            this.btn_LuuHoiVien.Click += Btn_LuuHoiVien_Click;
            

        }

  
        private void Btn_LuuHoiVien_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = txt_MaHoiVien.Text; // Dùng mã đã sinh tự động
            kh.TenKH = txt_HoVaTenHoiVien.Text;

            if (!int.TryParse(txt_NamSinh.Text, out int namSinh))
            {
                MessageBox.Show("Năm sinh không hợp lệ!");
                return;
            }
            kh.NamSinh = namSinh;

            kh.Sdt = txt_SDT.Text;
            kh.GioiTinh = cbo_GioiTinh.Text;
            kh.Email = txt_Email.Text;
            // kh.TinhTrang = "Hoạt động"; // Gán mặc định

            // 2. Xử lý ảnh
            string duongDanDeLuuVaoCSDL = "";
            if (pic_PictureMember.Tag != null)
            {
                string duongDanGoc = pic_PictureMember.Tag.ToString();
                string tenFileMoi = kh.MaKH + Path.GetExtension(duongDanGoc);
                string thuMucDich = Path.Combine(Application.StartupPath, "Images", "HoiVien");

                if (!Directory.Exists(thuMucDich))
                {
                    Directory.CreateDirectory(thuMucDich);
                }

                string duongDanMoi = Path.Combine(thuMucDich, tenFileMoi);
                File.Copy(duongDanGoc, duongDanMoi, true);
                duongDanDeLuuVaoCSDL = Path.Combine("Images", "HoiVien", tenFileMoi);
            }
            kh.HinhAnh = duongDanDeLuuVaoCSDL;

            // 3. Gọi BUS để THÊM
            try
            {
                if (khBus.ThemKH(kh))
                {
                    MessageBox.Show("Thêm hội viên thành công!");
                    this.Close(); // Đóng form sau khi thêm
                }
                else
                {
                    MessageBox.Show("Thêm hội viên thất bại!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }
        
        private void FrmAddMember_Load(object sender, EventArgs e)
        {
            this.Text = "Thêm hội viên mới";

            // Nạp dữ liệu cho ComboBox
            this.cbo_GioiTinh.Items.Add("Nam");
            this.cbo_GioiTinh.Items.Add("Nữ");
            this.cbo_GioiTinh.SelectedIndex = 0; // Chọn "Nam" làm mặc định

            // Sinh mã tự động và gán vào
            txt_MaHoiVien.Text = khBus.TuDongSinhMaKH();
            txt_MaHoiVien.Enabled = false; // Không cho sửa Mã

        }

        private void Pic_PictureMember_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            dialog.Title = "Hãy chọn một hình ảnh";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedImagePath = dialog.FileName;
                    pic_PictureMember.Image = new Bitmap(selectedImagePath);
                    pic_PictureMember.SizeMode = PictureBoxSizeMode.Zoom;
                    pic_PictureMember.BackgroundImage = null;

                    // Gán đường dẫn vào .Tag để nút Lưu có thể dùng
                    pic_PictureMember.Tag = selectedImagePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: Không thể tải hình ảnh. " + ex.Message);
                }
            }
        }

       
    }
}
