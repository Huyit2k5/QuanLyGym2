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
using QuanLyGym.BUS;
using QuanLyGym.Modals;

namespace QuanLyGym.Forms.Components
{
    public partial class frmAddTrainner : Form
    {
        HuanLuyenVienBUS hlvBus = new HuanLuyenVienBUS();

        public frmAddTrainner()
        {
            InitializeComponent();
            this.ptb_HLV.Click += Ptb_HLV_Click;
            this.btn_SaveAddHLV.Click += BtnLuuHLV_Click;
            this.Load += FrmAddTrainner_Load;

        }

        private void FrmAddTrainner_Load(object sender, EventArgs e)
        {
            this.cbo_GioiTinh.Items.Add("Nam");
            this.cbo_GioiTinh.Items.Add("Nữ");
            this.cbo_GioiTinh.SelectedIndex = 0;

            txt_MaHLV.Text = hlvBus.TuDongSinhMaHLV();
            txt_MaHLV.Enabled = false; // Không cho sửa Mã
        }

        private void Ptb_HLV_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            dialog.Title = "Hãy chọn một hình ảnh";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string selectedImagePath = dialog.FileName;
                    ptb_HLV.Image = new Bitmap(selectedImagePath);
                    ptb_HLV.SizeMode = PictureBoxSizeMode.StretchImage;
                    ptb_HLV.BackgroundImage = null;

                    // === THÊM DÒNG NÀY (RẤT QUAN TRỌNG) ===
                    // Lưu đường dẫn gốc vào Tag để nút Lưu sử dụng
                    ptb_HLV.Tag = selectedImagePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: Không thể tải hình ảnh. " + ex.Message);
                }
            }
        }

        // THÊM HÀM MỚI: Sự kiện Click cho nút Lưu
        private void BtnLuuHLV_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu từ Form
            HuanLuyenVien hlv = new HuanLuyenVien();
            hlv.TenHLV = txt_TenHLV.Text; // (Giả sử tên control là txtTenHLV)
            hlv.GioiTinh = cbo_GioiTinh.Text;
            hlv.ChuyenMon = txt_ChuyenMon.Text;
            hlv.Sdt = txt_SDT.Text;
            hlv.NamKinhNghiem = int.Parse(txt_SoNamKinhNghiem.Text); // (Dùng NumericUpDown)

            // 2. Xử lý ảnh (Giống hệt code của frmAddMember)
            string duongDanDeLuuVaoCSDL = "";
            if (ptb_HLV.Tag != null) // Kiểm tra xem có ảnh mới không
            {
                string duongDanGoc = ptb_HLV.Tag.ToString();

                // Lấy Mã HLV mới (để làm tên file)
                string maHLV_Moi = hlvBus.TuDongSinhMaHLV(); // "HLV004"
                string tenFileMoi = maHLV_Moi + Path.GetExtension(duongDanGoc); // "HLV004.jpg"

                // Tạo đường dẫn lưu (ví dụ: .../bin/Debug/Images/HLV/HLV004.jpg)
                string thuMucDich = Path.Combine(Application.StartupPath, "Images", "HLV");
                if (!Directory.Exists(thuMucDich))
                {
                    Directory.CreateDirectory(thuMucDich);
                }
                string duongDanMoi = Path.Combine(thuMucDich, tenFileMoi);

                File.Copy(duongDanGoc, duongDanMoi, true); // Copy ảnh vào thư mục

                // Đây là thứ ta lưu vào CSDL
                duongDanDeLuuVaoCSDL = Path.Combine("Images", "HLV", tenFileMoi);
            }

            hlv.HinhAnh = duongDanDeLuuVaoCSDL;

            // 3. Gọi BUS để lưu
            try
            {
                if (hlvBus.ThemHLV(hlv))
                {
                    MessageBox.Show("Thêm huấn luyện viên thành công!");
                    this.Close(); // Đóng form
                }
                else
                {
                    MessageBox.Show("Thêm thất bại. Lỗi CSDL.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    
    }
}
