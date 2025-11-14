namespace QuanLyGym.Forms
{
    partial class frmHuanLuyenVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_DanhSachHocVienCuaHLV = new System.Windows.Forms.DataGridView();
            this.Col_MaHV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenHocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_DanhSachCacLopHLV = new System.Windows.Forms.DataGridView();
            this.col_MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoLuongHocVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DanhSachHLV = new System.Windows.Forms.DataGridView();
            this.col_MaHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ChuyenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SDTHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NamKinhNghiemHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ThemHLV = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHocVienCuaHLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachCacLopHLV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHLV)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_DanhSachHocVienCuaHLV
            // 
            this.dgv_DanhSachHocVienCuaHLV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachHocVienCuaHLV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachHocVienCuaHLV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_MaHV,
            this.col_TenHocVien,
            this.col_NgayBatDau,
            this.col_NgayKetThuc});
            this.dgv_DanhSachHocVienCuaHLV.Location = new System.Drawing.Point(1033, 170);
            this.dgv_DanhSachHocVienCuaHLV.Name = "dgv_DanhSachHocVienCuaHLV";
            this.dgv_DanhSachHocVienCuaHLV.RowHeadersWidth = 51;
            this.dgv_DanhSachHocVienCuaHLV.RowTemplate.Height = 24;
            this.dgv_DanhSachHocVienCuaHLV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachHocVienCuaHLV.Size = new System.Drawing.Size(591, 597);
            this.dgv_DanhSachHocVienCuaHLV.TabIndex = 11;
            // 
            // Col_MaHV
            // 
            this.Col_MaHV.DataPropertyName = "MaKH";
            this.Col_MaHV.HeaderText = "Mã hội viên";
            this.Col_MaHV.MinimumWidth = 6;
            this.Col_MaHV.Name = "Col_MaHV";
            // 
            // col_TenHocVien
            // 
            this.col_TenHocVien.DataPropertyName = "TenKH";
            this.col_TenHocVien.HeaderText = "Tên học viên";
            this.col_TenHocVien.MinimumWidth = 6;
            this.col_TenHocVien.Name = "col_TenHocVien";
            // 
            // col_NgayBatDau
            // 
            this.col_NgayBatDau.DataPropertyName = "NgayBatDau";
            this.col_NgayBatDau.HeaderText = "Ngày bắt đầu";
            this.col_NgayBatDau.MinimumWidth = 6;
            this.col_NgayBatDau.Name = "col_NgayBatDau";
            // 
            // col_NgayKetThuc
            // 
            this.col_NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.col_NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.col_NgayKetThuc.MinimumWidth = 6;
            this.col_NgayKetThuc.Name = "col_NgayKetThuc";
            // 
            // dgv_DanhSachCacLopHLV
            // 
            this.dgv_DanhSachCacLopHLV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachCacLopHLV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachCacLopHLV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaLop,
            this.col_TenLop,
            this.col_SoLuongHocVien});
            this.dgv_DanhSachCacLopHLV.Location = new System.Drawing.Point(1033, 170);
            this.dgv_DanhSachCacLopHLV.Name = "dgv_DanhSachCacLopHLV";
            this.dgv_DanhSachCacLopHLV.RowHeadersWidth = 51;
            this.dgv_DanhSachCacLopHLV.RowTemplate.Height = 24;
            this.dgv_DanhSachCacLopHLV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachCacLopHLV.Size = new System.Drawing.Size(591, 597);
            this.dgv_DanhSachCacLopHLV.TabIndex = 19;
            // 
            // col_MaLop
            // 
            this.col_MaLop.DataPropertyName = "MaLop";
            this.col_MaLop.HeaderText = "Mã lớp";
            this.col_MaLop.MinimumWidth = 6;
            this.col_MaLop.Name = "col_MaLop";
            // 
            // col_TenLop
            // 
            this.col_TenLop.DataPropertyName = "TenLop";
            this.col_TenLop.HeaderText = "Tên lớp";
            this.col_TenLop.MinimumWidth = 6;
            this.col_TenLop.Name = "col_TenLop";
            // 
            // col_SoLuongHocVien
            // 
            this.col_SoLuongHocVien.DataPropertyName = "SoLuong";
            this.col_SoLuongHocVien.HeaderText = "Số lượng";
            this.col_SoLuongHocVien.MinimumWidth = 6;
            this.col_SoLuongHocVien.Name = "col_SoLuongHocVien";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Danh sách huấn luyện viên";
            // 
            // dgv_DanhSachHLV
            // 
            this.dgv_DanhSachHLV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachHLV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachHLV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaHLV,
            this.col_TenHLV,
            this.col_GioiTinh,
            this.col_ChuyenMon,
            this.col_SDTHLV,
            this.col_NamKinhNghiemHLV});
            this.dgv_DanhSachHLV.Location = new System.Drawing.Point(12, 54);
            this.dgv_DanhSachHLV.Name = "dgv_DanhSachHLV";
            this.dgv_DanhSachHLV.RowHeadersWidth = 51;
            this.dgv_DanhSachHLV.RowTemplate.Height = 24;
            this.dgv_DanhSachHLV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachHLV.Size = new System.Drawing.Size(958, 713);
            this.dgv_DanhSachHLV.TabIndex = 21;
            // 
            // col_MaHLV
            // 
            this.col_MaHLV.DataPropertyName = "MaHLV";
            this.col_MaHLV.HeaderText = "Mã HLV";
            this.col_MaHLV.MinimumWidth = 6;
            this.col_MaHLV.Name = "col_MaHLV";
            // 
            // col_TenHLV
            // 
            this.col_TenHLV.DataPropertyName = "TenHLV";
            this.col_TenHLV.HeaderText = "Họ và tên";
            this.col_TenHLV.MinimumWidth = 6;
            this.col_TenHLV.Name = "col_TenHLV";
            // 
            // col_GioiTinh
            // 
            this.col_GioiTinh.DataPropertyName = "GioiTinh";
            this.col_GioiTinh.HeaderText = "Giới tính";
            this.col_GioiTinh.MinimumWidth = 6;
            this.col_GioiTinh.Name = "col_GioiTinh";
            // 
            // col_ChuyenMon
            // 
            this.col_ChuyenMon.DataPropertyName = "ChuyenMon";
            this.col_ChuyenMon.HeaderText = "Chuyên môn";
            this.col_ChuyenMon.MinimumWidth = 6;
            this.col_ChuyenMon.Name = "col_ChuyenMon";
            // 
            // col_SDTHLV
            // 
            this.col_SDTHLV.DataPropertyName = "SDT";
            this.col_SDTHLV.HeaderText = "Số điện thoại";
            this.col_SDTHLV.MinimumWidth = 6;
            this.col_SDTHLV.Name = "col_SDTHLV";
            // 
            // col_NamKinhNghiemHLV
            // 
            this.col_NamKinhNghiemHLV.DataPropertyName = "NamKinhNghiem";
            this.col_NamKinhNghiemHLV.HeaderText = "Số năm kinh nghiệm";
            this.col_NamKinhNghiemHLV.MinimumWidth = 6;
            this.col_NamKinhNghiemHLV.Name = "col_NamKinhNghiemHLV";
            // 
            // btn_ThemHLV
            // 
            this.btn_ThemHLV.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_ThemHLV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemHLV.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_ThemHLV.Location = new System.Drawing.Point(1033, 54);
            this.btn_ThemHLV.Name = "btn_ThemHLV";
            this.btn_ThemHLV.Size = new System.Drawing.Size(591, 75);
            this.btn_ThemHLV.TabIndex = 20;
            this.btn_ThemHLV.Text = "Thêm huấn luyện viên";
            this.btn_ThemHLV.UseVisualStyleBackColor = false;
            // 
            // frmHuanLuyenVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1692, 783);
            this.Controls.Add(this.dgv_DanhSachHLV);
            this.Controls.Add(this.btn_ThemHLV);
            this.Controls.Add(this.dgv_DanhSachHocVienCuaHLV);
            this.Controls.Add(this.dgv_DanhSachCacLopHLV);
            this.Controls.Add(this.label1);
            this.Name = "frmHuanLuyenVien";
            this.Text = "frmHuanLuyenVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHocVienCuaHLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachCacLopHLV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachHLV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DanhSachHocVienCuaHLV;
        private System.Windows.Forms.DataGridView dgv_DanhSachCacLopHLV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DanhSachHLV;
        private System.Windows.Forms.Button btn_ThemHLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaHLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenHLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ChuyenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SDTHLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NamKinhNghiemHLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaHV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenHocVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoLuongHocVien;
    }
}