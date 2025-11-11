using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyGym.BUS;
using QuanLyGym.Forms.Components;

namespace QuanLyGym.Forms
{
    public partial class frmHuanLuyenVien : Form
    {
        HuanLuyenVienBUS hlvBUS = new HuanLuyenVienBUS();
        
        BindingSource bsMaster = new BindingSource();
        BindingSource bsClass = new BindingSource();
        BindingSource bsMember = new BindingSource();
        public frmHuanLuyenVien()
        {
            InitializeComponent();
            this.dgv_DanhSachHLV.SelectionChanged += Dgv_DanhSachHLV_SelectionChanged;
            this.Load += FrmHuanLuyenVien_Load;

            this.btn_ThemHLV.Click += Btn_ThemHLV_Click;
           
        }

        private void Btn_ThemHLV_Click(object sender, EventArgs e)
        {
            frmAddTrainner frmAddTrainner = new frmAddTrainner();
            frmAddTrainner.ShowDialog();
        }

        private void FrmHuanLuyenVien_Load(object sender, EventArgs e)
        {
            bsMaster.DataSource = hlvBUS.GetAllHLV();
            dgv_DanhSachHLV.DataSource = bsMaster;

            
            dgv_DanhSachHLV.AllowUserToAddRows = false;
            dgv_DanhSachHLV.ReadOnly = true;
        }

        private void Btn_AddHLV_Click(object sender, EventArgs e)
        {
            frmAddTrainner addtrainer = new frmAddTrainner();
            addtrainer.Show();

        }

        private void Dgv_DanhSachHLV_SelectionChanged(object sender, EventArgs e)
        {
            //Kiểm tra xem có dòng nào được chọn không
            if (dgv_DanhSachHLV.CurrentRow == null)
            {
                return;
            }

            // 2. Lấy MaHLV (để tải dữ liệu)
            string maHLV = dgv_DanhSachHLV.CurrentRow.Cells["col_MaHLV"].Value.ToString();

            // 3. Lấy CHUYÊN MÔN (để quyết định)
           
            string chuyenMon = "";
            if (dgv_DanhSachHLV.CurrentRow.Cells["col_ChuyenMon"].Value != DBNull.Value)
            {
                chuyenMon = dgv_DanhSachHLV.CurrentRow.Cells["col_ChuyenMon"].Value.ToString();
            }

            
            // "nếu chuyên môn có chữ PT cá nhân"
            if (chuyenMon.Contains("PT") || chuyenMon.Contains("cá nhân"))
            {
                // Tải dữ liệu cho dgv HỌC VIÊN
                LoadHocVienPT(maHLV);

                // Đưa dgv HỌC VIÊN (Member) lên trên
                dgv_DanhSachHocVienCuaHLV.BringToFront();
            }
            else // Nếu chuyên môn là bất cứ thứ gì khác (ví dụ: Yoga, Gym cơ bản...)
            {
                // Tải dữ liệu cho dgv LỚP
                LoadLopHoc(maHLV);

                // Đưa dgv LỚP lên trên
                dgv_DanhSachCacLopHLV.BringToFront();
            }
        }

        private void LoadHocVienPT(string maHLV)
        {
            
            dgv_DanhSachHocVienCuaHLV.DataSource = hlvBUS.GetHocVien_ByHLV(maHLV);
        }

        
        private void LoadLopHoc(string maHLV)
        {
            
            dgv_DanhSachCacLopHLV.DataSource = hlvBUS.GetLop_ByHLV(maHLV);
        }

        public void LoadLaiLuoiMaster()
        {
            bsMaster.DataSource = hlvBUS.GetAllHLV();
            dgv_DanhSachHLV.DataSource = bsMaster;
        }
    }
}
