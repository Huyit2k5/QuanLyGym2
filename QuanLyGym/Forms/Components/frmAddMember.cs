using QuanLyGym.BUS;
using QuanLyGym.Modals;
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
    public partial class frmAddMember : Form
    {
        BindingSource _source;
        public frmAddMember(bool view = false)
        {
            InitializeComponent();
            this.CenterToParent();
            this.pic_PictureMember.Click += Pic_PictureMember_Click;
            this.txt_MaHoiVien.Enabled = false;
            if (view)
            {
                txt_HoVaTenHoiVien.Enabled = false;
                txt_MaHoiVien.Enabled = false;
                txt_SDT.Enabled = false;
                
            }
          this.Load += FrmAddMember_Load;
            this.btn_LuuHoiVien.Click += Btn_LuuHoiVien_Click;

        }

        public frmAddMember(BindingSource source)
        {
            _source = source;
        }
        private void Btn_LuuHoiVien_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            KhachHangBUS khBus = new KhachHangBUS();
            kh.TenKH = txt_HoVaTenHoiVien.Text;
            kh.NamSinh = int.Parse(txt_NamSinh.Text);
            kh.Sdt = txt_SDT.Text;
            kh.GioiTinh = cbo_GioiTinh.Text;
            kh.Email = txt_Email.Text;
            kh.TinhTrang = cbo_TinhTrang.Text;


            if (khBus.ThemKH(kh)){
                MessageBox.Show("Thêm hội viên thành công!");
            }
            else
            {
                MessageBox.Show("Thêm hội viên thất bại!");
            }
        }
        private void FrmAddMember_Load(object sender, EventArgs e)
        {
            this.cbo_GioiTinh.Items.Add("Nam");
            this.cbo_GioiTinh.Items.Add("Nữ");
            if (_source != null)
            {
                // Binding các textbox với dữ liệu hiện tại
                txt_MaHoiVien.DataBindings.Add("Text", _source, "MaKH");
                txt_HoVaTenHoiVien.DataBindings.Add("Text", _source, "TenKH");
                txt_NamSinh.DataBindings.Add("Text", _source, "NamSinh");
                txt_SDT.DataBindings.Add("Text", _source, "SDT");
                cbo_GioiTinh.DataBindings.Add("Text", _source, "GioiTinh");
                txt_Email.DataBindings.Add("Text", _source, "Email");
                cbo_TinhTrang.DataBindings.Add("Text", _source, "TinhTrang");
            }
        }

        private void Pic_PictureMember_Click(object sender, EventArgs e)
        {
            // 1. TẠO ĐỐI TƯỢNG OPENFILEDIALOG
            // Bạn có thể dùng 'openFileDialog1' nếu đã kéo vào, 
            // hoặc tạo mới như thế này:
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
                    pic_PictureMember.Image = new Bitmap(selectedImagePath);

                    // (Tùy chọn) Chỉnh chế độ hiển thị cho vừa khung
                    pic_PictureMember.SizeMode = PictureBoxSizeMode.Zoom;
                    pic_PictureMember.BackgroundImage = null ;
                }
                catch (Exception ex)
                {
                    // Xử lý nếu file không phải là ảnh hợp lệ
                    MessageBox.Show("Lỗi: Không thể tải hình ảnh. " + ex.Message);
                }
            }
        }

        public void BingDingSource(DataTable dt)
        {
            txt_MaHoiVien.Text = dt.Rows[0]["MaHoiVien"].ToString();
            txt_HoVaTenHoiVien.Text = dt.Rows[0]["HoVaTenHoiVien"].ToString();
            txt_NamSinh.Text = dt.Rows[0]["NamSinh"].ToString();
            txt_SDT.Text = dt.Rows[0]["SDT"].ToString();
            cbo_GioiTinh.Text = dt.Rows[0]["GioiTinh"].ToString();
            txt_Email.Text = dt.Rows[0]["Email"].ToString();
            cbo_TinhTrang.Text = dt.Rows[0]["TinhTrang"].ToString();
        }
    }
}
