namespace QuanLyGym.Forms
{
    partial class frmLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv_HoiVienCuaLop = new System.Windows.Forms.DataGridView();
            this.Col_MaHoiVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SearchLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DanhSachCacLop = new System.Windows.Forms.DataGridView();
            this.col_MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SucChua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_ThemLop = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoiVienCuaLop)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachCacLop)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 729F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1628, 922);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dgv_HoiVienCuaLop);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(902, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(723, 916);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã hội viên";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 31);
            this.textBox1.TabIndex = 24;
            // 
            // dgv_HoiVienCuaLop
            // 
            this.dgv_HoiVienCuaLop.AllowUserToAddRows = false;
            this.dgv_HoiVienCuaLop.AllowUserToDeleteRows = false;
            this.dgv_HoiVienCuaLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HoiVienCuaLop.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_HoiVienCuaLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HoiVienCuaLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_MaHoiVien,
            this.col_NgayBatDau,
            this.col_HoVaTen,
            this.col_NgayKetThuc});
            this.dgv_HoiVienCuaLop.Location = new System.Drawing.Point(19, 147);
            this.dgv_HoiVienCuaLop.Name = "dgv_HoiVienCuaLop";
            this.dgv_HoiVienCuaLop.RowHeadersWidth = 51;
            this.dgv_HoiVienCuaLop.RowTemplate.Height = 24;
            this.dgv_HoiVienCuaLop.Size = new System.Drawing.Size(695, 644);
            this.dgv_HoiVienCuaLop.TabIndex = 23;
            // 
            // Col_MaHoiVien
            // 
            this.Col_MaHoiVien.DataPropertyName = "MaKH";
            this.Col_MaHoiVien.HeaderText = "Mã Hội viên";
            this.Col_MaHoiVien.MinimumWidth = 6;
            this.Col_MaHoiVien.Name = "Col_MaHoiVien";
            // 
            // col_NgayBatDau
            // 
            this.col_NgayBatDau.DataPropertyName = "NgayBatDau";
            this.col_NgayBatDau.HeaderText = "Ngày Bắt đầu";
            this.col_NgayBatDau.MinimumWidth = 6;
            this.col_NgayBatDau.Name = "col_NgayBatDau";
            // 
            // col_HoVaTen
            // 
            this.col_HoVaTen.DataPropertyName = "TenKH";
            this.col_HoVaTen.HeaderText = "Họ và tên";
            this.col_HoVaTen.MinimumWidth = 6;
            this.col_HoVaTen.Name = "col_HoVaTen";
            // 
            // col_NgayKetThuc
            // 
            this.col_NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.col_NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.col_NgayKetThuc.MinimumWidth = 6;
            this.col_NgayKetThuc.Name = "col_NgayKetThuc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_SearchLop);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgv_DanhSachCacLop);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(893, 916);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tìm kiếm";
            // 
            // txt_SearchLop
            // 
            this.txt_SearchLop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_SearchLop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_SearchLop.Location = new System.Drawing.Point(129, 119);
            this.txt_SearchLop.Name = "txt_SearchLop";
            this.txt_SearchLop.Size = new System.Drawing.Size(424, 22);
            this.txt_SearchLop.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Danh sách lớp";
            // 
            // dgv_DanhSachCacLop
            // 
            this.dgv_DanhSachCacLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSachCacLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachCacLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachCacLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaLop,
            this.col_TenLop,
            this.col_MaHLV,
            this.col_SoLuong,
            this.col_SucChua,
            this.col_HocPhi});
            this.dgv_DanhSachCacLop.Location = new System.Drawing.Point(0, 147);
            this.dgv_DanhSachCacLop.Name = "dgv_DanhSachCacLop";
            this.dgv_DanhSachCacLop.RowHeadersWidth = 51;
            this.dgv_DanhSachCacLop.RowTemplate.Height = 24;
            this.dgv_DanhSachCacLop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachCacLop.Size = new System.Drawing.Size(863, 644);
            this.dgv_DanhSachCacLop.TabIndex = 21;
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
            // col_MaHLV
            // 
            this.col_MaHLV.DataPropertyName = "MaHLV";
            this.col_MaHLV.HeaderText = "Mã huấn luyện viên";
            this.col_MaHLV.MinimumWidth = 6;
            this.col_MaHLV.Name = "col_MaHLV";
            // 
            // col_SoLuong
            // 
            this.col_SoLuong.DataPropertyName = "SiSoHienTai";
            this.col_SoLuong.HeaderText = "Số lượng";
            this.col_SoLuong.MinimumWidth = 6;
            this.col_SoLuong.Name = "col_SoLuong";
            // 
            // col_SucChua
            // 
            this.col_SucChua.DataPropertyName = "SucChua";
            this.col_SucChua.HeaderText = "Sức chứa";
            this.col_SucChua.MinimumWidth = 6;
            this.col_SucChua.Name = "col_SucChua";
            // 
            // col_HocPhi
            // 
            this.col_HocPhi.DataPropertyName = "HocPhi";
            this.col_HocPhi.HeaderText = "Học phí";
            this.col_HocPhi.MinimumWidth = 6;
            this.col_HocPhi.Name = "col_HocPhi";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ThemLop});
            this.toolStrip1.Location = new System.Drawing.Point(3, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(887, 27);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_ThemLop
            // 
            this.btn_ThemLop.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemLop.Image")));
            this.btn_ThemLop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ThemLop.Name = "btn_ThemLop";
            this.btn_ThemLop.Size = new System.Drawing.Size(70, 24);
            this.btn_ThemLop.Text = "Thêm";
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 922);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmLop";
            this.Text = "frmLop";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HoiVienCuaLop)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachCacLop)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv_HoiVienCuaLop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_DanhSachCacLop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SearchLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaHoiVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaHLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SucChua;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HocPhi;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_ThemLop;
    }
}