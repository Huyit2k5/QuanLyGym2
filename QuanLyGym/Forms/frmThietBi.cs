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
using QuanLyGym.Modals;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyGym.Forms
{
    public partial class frmThietBi : Form
    {
        ThietBiBUS thietBiBUS = new ThietBiBUS();
        BindingSource bsMaster = new BindingSource();
        BindingSource bsDetail = new BindingSource();
        public frmThietBi()
        {
            InitializeComponent();
            this.Load += FrmThietBi_Load;
           
            this.dgv_DanhSachThietBi.SelectionChanged += Dgv_DanhSachThietBi_SelectionChanged;
        }

        private void Dgv_DanhSachThietBi_SelectionChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào đang được chọn không
            if (dgv_DanhSachThietBi.CurrentRow != null)
            {
                // 1. Lấy MaThietBi từ dòng đang chọn của lưới Master
                string maThietBi = dgv_DanhSachThietBi.CurrentRow.Cells["col_MaThietBi"].Value.ToString();

                // 2. Tải lưới Detail dựa theo mã đó
                LoadDetailGrid(maThietBi);
            }
            else
            {
                // Nếu không có gì ở lưới Master, hãy xóa lưới Detail
                bsDetail.DataSource = null;
                dgv_CTTB.DataSource = bsDetail;
            }
        }

        private void FrmThietBi_Load(object sender, EventArgs e)
        {
            LoadMasterGrid();
        }

        public void LoadMasterGrid()
        {
            // Lấy dữ liệu (đã COUNT SoLuong) từ BUS
            bsMaster.DataSource = thietBiBUS.GetAllTB_WithCount();

            // Gán vào DataGridView
            dgv_DanhSachThietBi.DataSource = bsMaster;

            
        }

        // 4. Hàm tải Lưới Detail (Hàm mới cho form này)
        public void LoadDetailGrid(string maThietBi)
        {
            // Lấy dữ liệu chi tiết từ BUS
            bsDetail.DataSource = thietBiBUS.GetChiTiet_ByMaTB(maThietBi);

            // Gán vào DataGridView
            dgv_CTTB.DataSource = bsDetail;
        }
    }
}
