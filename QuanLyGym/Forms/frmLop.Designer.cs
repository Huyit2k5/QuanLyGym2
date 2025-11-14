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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_Members = new System.Windows.Forms.DataGridView();
            this.col_TinhTrangGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_MaHoiVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddMember = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_DanhSachCacLopHLV = new System.Windows.Forms.DataGridView();
            this.col_MaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_MaHLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HocPhi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Members)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachCacLopHLV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 512F));
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
            // dgv_Members
            // 
            this.dgv_Members.AllowUserToAddRows = false;
            this.dgv_Members.AllowUserToDeleteRows = false;
            this.dgv_Members.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Members.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_Members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Members.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_MaHoiVien,
            this.col_HoVaTen,
            this.col_TinhTrangGoi});
            this.dgv_Members.Location = new System.Drawing.Point(19, 147);
            this.dgv_Members.Name = "dgv_Members";
            this.dgv_Members.RowHeadersWidth = 51;
            this.dgv_Members.RowTemplate.Height = 24;
            this.dgv_Members.Size = new System.Drawing.Size(467, 644);
            this.dgv_Members.TabIndex = 23;
            // 
            // col_TinhTrangGoi
            // 
            this.col_TinhTrangGoi.DataPropertyName = "TinhTrang";
            this.col_TinhTrangGoi.HeaderText = "Tình trạng";
            this.col_TinhTrangGoi.MinimumWidth = 6;
            this.col_TinhTrangGoi.Name = "col_TinhTrangGoi";
            // 
            // col_HoVaTen
            // 
            this.col_HoVaTen.DataPropertyName = "TenKH";
            this.col_HoVaTen.HeaderText = "Họ và tên";
            this.col_HoVaTen.MinimumWidth = 6;
            this.col_HoVaTen.Name = "col_HoVaTen";
            // 
            // Col_MaHoiVien
            // 
            this.Col_MaHoiVien.DataPropertyName = "MaKH";
            this.Col_MaHoiVien.HeaderText = "Mã Hội viên";
            this.Col_MaHoiVien.MinimumWidth = 6;
            this.Col_MaHoiVien.Name = "Col_MaHoiVien";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 81);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 31);
            this.textBox1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã hội viên";
            // 
            // btn_AddMember
            // 
            this.btn_AddMember.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_AddMember.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddMember.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_AddMember.Location = new System.Drawing.Point(316, 81);
            this.btn_AddMember.Name = "btn_AddMember";
            this.btn_AddMember.Size = new System.Drawing.Size(170, 31);
            this.btn_AddMember.TabIndex = 26;
            this.btn_AddMember.Text = "Thêm hội viên";
            this.btn_AddMember.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AddMember);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.dgv_Members);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(1119, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 916);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dgv_DanhSachCacLopHLV);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1110, 916);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // dgv_DanhSachCacLopHLV
            // 
            this.dgv_DanhSachCacLopHLV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_DanhSachCacLopHLV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachCacLopHLV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachCacLopHLV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaLop,
            this.col_TenLop,
            this.col_MaHLV,
            this.col_SoLuong,
            this.col_HocPhi});
            this.dgv_DanhSachCacLopHLV.Location = new System.Drawing.Point(0, 147);
            this.dgv_DanhSachCacLopHLV.Name = "dgv_DanhSachCacLopHLV";
            this.dgv_DanhSachCacLopHLV.RowHeadersWidth = 51;
            this.dgv_DanhSachCacLopHLV.RowTemplate.Height = 24;
            this.dgv_DanhSachCacLopHLV.Size = new System.Drawing.Size(1104, 644);
            this.dgv_DanhSachCacLopHLV.TabIndex = 21;
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
            this.col_SoLuong.DataPropertyName = "SoLuong";
            this.col_SoLuong.HeaderText = "Số lượng";
            this.col_SoLuong.MinimumWidth = 6;
            this.col_SoLuong.Name = "col_SoLuong";
            // 
            // col_HocPhi
            // 
            this.col_HocPhi.DataPropertyName = "HocPhi";
            this.col_HocPhi.HeaderText = "Học phí";
            this.col_HocPhi.MinimumWidth = 6;
            this.col_HocPhi.Name = "col_HocPhi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(450, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 22;
            this.label1.Text = "Danh sách lớp";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Members)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachCacLopHLV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv_Members;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaHoiVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TinhTrangGoi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_DanhSachCacLopHLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaHLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HocPhi;
        private System.Windows.Forms.Label label1;
    }
}