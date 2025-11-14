namespace QuanLyGym.Forms
{
    partial class frmThietBi
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_DanhSachThietBi = new System.Windows.Forms.DataGridView();
            this.col_MaThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_LoaiThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoLuongThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv_CTTB = new System.Windows.Forms.DataGridView();
            this.Col_MaChiTietThietBi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoHieuMay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HangSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TinhTrangGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SearchMember = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachThietBi)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTTB)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(452, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Danh sách thiệt bị";
            // 
            // dgv_DanhSachThietBi
            // 
            this.dgv_DanhSachThietBi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSachThietBi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachThietBi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachThietBi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaThietBi,
            this.col_TenLop,
            this.col_LoaiThietBi,
            this.col_SoLuongThietBi});
            this.dgv_DanhSachThietBi.Location = new System.Drawing.Point(0, 147);
            this.dgv_DanhSachThietBi.Name = "dgv_DanhSachThietBi";
            this.dgv_DanhSachThietBi.RowHeadersWidth = 51;
            this.dgv_DanhSachThietBi.RowTemplate.Height = 24;
            this.dgv_DanhSachThietBi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachThietBi.Size = new System.Drawing.Size(1078, 644);
            this.dgv_DanhSachThietBi.TabIndex = 21;
            // 
            // col_MaThietBi
            // 
            this.col_MaThietBi.DataPropertyName = "MaThietBi";
            this.col_MaThietBi.HeaderText = "Mã thiết bị";
            this.col_MaThietBi.MinimumWidth = 6;
            this.col_MaThietBi.Name = "col_MaThietBi";
            // 
            // col_TenLop
            // 
            this.col_TenLop.DataPropertyName = "TenThietBi";
            this.col_TenLop.HeaderText = "Tên thiết bị";
            this.col_TenLop.MinimumWidth = 6;
            this.col_TenLop.Name = "col_TenLop";
            // 
            // col_LoaiThietBi
            // 
            this.col_LoaiThietBi.DataPropertyName = "LoaiThietBi";
            this.col_LoaiThietBi.HeaderText = "Loại thiết bị";
            this.col_LoaiThietBi.MinimumWidth = 6;
            this.col_LoaiThietBi.Name = "col_LoaiThietBi";
            // 
            // col_SoLuongThietBi
            // 
            this.col_SoLuongThietBi.DataPropertyName = "SoLuong";
            this.col_SoLuongThietBi.HeaderText = "Số lượng";
            this.col_SoLuongThietBi.MinimumWidth = 6;
            this.col_SoLuongThietBi.Name = "col_SoLuongThietBi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dgv_CTTB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(1093, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 858);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(408, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Chi tiết thiết bị";
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(139, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 22);
            this.textBox1.TabIndex = 25;
            this.textBox1.Tag = "";
            // 
            // dgv_CTTB
            // 
            this.dgv_CTTB.AllowUserToAddRows = false;
            this.dgv_CTTB.AllowUserToDeleteRows = false;
            this.dgv_CTTB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_CTTB.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_CTTB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_CTTB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_MaChiTietThietBi,
            this.col_MaTB,
            this.col_SoHieuMay,
            this.col_HangSX,
            this.col_NgayNhap,
            this.col_TinhTrangGoi});
            this.dgv_CTTB.Location = new System.Drawing.Point(19, 147);
            this.dgv_CTTB.Name = "dgv_CTTB";
            this.dgv_CTTB.RowHeadersWidth = 51;
            this.dgv_CTTB.RowTemplate.Height = 24;
            this.dgv_CTTB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_CTTB.Size = new System.Drawing.Size(812, 644);
            this.dgv_CTTB.TabIndex = 23;
            // 
            // Col_MaChiTietThietBi
            // 
            this.Col_MaChiTietThietBi.DataPropertyName = "MaChiTietTB";
            this.Col_MaChiTietThietBi.HeaderText = "Mã chi tiết thiết bị";
            this.Col_MaChiTietThietBi.MinimumWidth = 6;
            this.Col_MaChiTietThietBi.Name = "Col_MaChiTietThietBi";
            // 
            // col_MaTB
            // 
            this.col_MaTB.DataPropertyName = "MaThietBi";
            this.col_MaTB.HeaderText = "Mã thiết bị";
            this.col_MaTB.MinimumWidth = 6;
            this.col_MaTB.Name = "col_MaTB";
            // 
            // col_SoHieuMay
            // 
            this.col_SoHieuMay.DataPropertyName = "SoHieuMay";
            this.col_SoHieuMay.HeaderText = "Số hiệu máy";
            this.col_SoHieuMay.MinimumWidth = 6;
            this.col_SoHieuMay.Name = "col_SoHieuMay";
            // 
            // col_HangSX
            // 
            this.col_HangSX.DataPropertyName = "HangSanXuat";
            this.col_HangSX.HeaderText = "Hãng sãn xuât";
            this.col_HangSX.MinimumWidth = 6;
            this.col_HangSX.Name = "col_HangSX";
            // 
            // col_NgayNhap
            // 
            this.col_NgayNhap.DataPropertyName = "NgayNhap";
            this.col_NgayNhap.HeaderText = "Ngày nhập";
            this.col_NgayNhap.MinimumWidth = 6;
            this.col_NgayNhap.Name = "col_NgayNhap";
            // 
            // col_TinhTrangGoi
            // 
            this.col_TinhTrangGoi.DataPropertyName = "TinhTrang";
            this.col_TinhTrangGoi.HeaderText = "Tình trạng";
            this.col_TinhTrangGoi.MinimumWidth = 6;
            this.col_TinhTrangGoi.Name = "col_TinhTrangGoi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_SearchMember);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgv_DanhSachThietBi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1084, 858);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Tìm kiếm";
            // 
            // txt_SearchMember
            // 
            this.txt_SearchMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_SearchMember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_SearchMember.Location = new System.Drawing.Point(130, 83);
            this.txt_SearchMember.Name = "txt_SearchMember";
            this.txt_SearchMember.Size = new System.Drawing.Size(333, 22);
            this.txt_SearchMember.TabIndex = 23;
            this.txt_SearchMember.Tag = "";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 834F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1924, 864);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // frmThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 864);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmThietBi";
            this.Text = "frmThietBi";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachThietBi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_CTTB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DanhSachThietBi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_CTTB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaChiTietThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoHieuMay;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HangSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TinhTrangGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_LoaiThietBi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoLuongThietBi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SearchMember;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
    }
}