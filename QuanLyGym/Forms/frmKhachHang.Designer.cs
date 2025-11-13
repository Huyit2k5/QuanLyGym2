namespace QuanLyGym.Forms
{
    partial class frmKhachHang
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.txt_SearchMember = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_Members = new System.Windows.Forms.DataGridView();
            this.Col_MaHoiVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_HoVaTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TinhTrangGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctt_SubFunctionMember = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChiTietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlb_Members = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tlr_Function = new System.Windows.Forms.ToolStrip();
            this.btn_AddMember = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Members)).BeginInit();
            this.ctt_SubFunctionMember.SuspendLayout();
            this.tlb_Members.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tlr_Function.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_SearchMember
            // 
            this.txt_SearchMember.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_SearchMember.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_SearchMember.Location = new System.Drawing.Point(129, 130);
            this.txt_SearchMember.Name = "txt_SearchMember";
            this.txt_SearchMember.Size = new System.Drawing.Size(333, 22);
            this.txt_SearchMember.TabIndex = 0;
            this.txt_SearchMember.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Danh sách hội viên";
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
            this.col_SoDienThoai,
            this.col_DiaChi,
            this.col_TinhTrangGoi});
            this.dgv_Members.ContextMenuStrip = this.ctt_SubFunctionMember;
            this.dgv_Members.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Members.Location = new System.Drawing.Point(3, 207);
            this.dgv_Members.Name = "dgv_Members";
            this.dgv_Members.RowHeadersWidth = 51;
            this.dgv_Members.RowTemplate.Height = 24;
            this.dgv_Members.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Members.Size = new System.Drawing.Size(1622, 710);
            this.dgv_Members.TabIndex = 3;
            // 
            // Col_MaHoiVien
            // 
            this.Col_MaHoiVien.DataPropertyName = "MaKH";
            this.Col_MaHoiVien.HeaderText = "Mã Hội viên";
            this.Col_MaHoiVien.MinimumWidth = 6;
            this.Col_MaHoiVien.Name = "Col_MaHoiVien";
            // 
            // col_HoVaTen
            // 
            this.col_HoVaTen.DataPropertyName = "TenKH";
            this.col_HoVaTen.HeaderText = "Họ và tên";
            this.col_HoVaTen.MinimumWidth = 6;
            this.col_HoVaTen.Name = "col_HoVaTen";
            // 
            // col_SoDienThoai
            // 
            this.col_SoDienThoai.DataPropertyName = "SDT";
            this.col_SoDienThoai.HeaderText = "Số điện thoại";
            this.col_SoDienThoai.MinimumWidth = 6;
            this.col_SoDienThoai.Name = "col_SoDienThoai";
            // 
            // col_DiaChi
            // 
            this.col_DiaChi.DataPropertyName = "GioiTinh";
            this.col_DiaChi.HeaderText = "GIới tính";
            this.col_DiaChi.MinimumWidth = 6;
            this.col_DiaChi.Name = "col_DiaChi";
            // 
            // col_TinhTrangGoi
            // 
            this.col_TinhTrangGoi.DataPropertyName = "TinhTrang";
            this.col_TinhTrangGoi.HeaderText = "Tình trạng";
            this.col_TinhTrangGoi.MinimumWidth = 6;
            this.col_TinhTrangGoi.Name = "col_TinhTrangGoi";
            // 
            // ctt_SubFunctionMember
            // 
            this.ctt_SubFunctionMember.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctt_SubFunctionMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoaToolStripMenuItem,
            this.suaToolStripMenuItem,
            this.ChiTietToolStripMenuItem});
            this.ctt_SubFunctionMember.Name = "ctt_SubFunctionMember";
            this.ctt_SubFunctionMember.Size = new System.Drawing.Size(126, 76);
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.xoaToolStripMenuItem.Text = "Xóa";
            // 
            // suaToolStripMenuItem
            // 
            this.suaToolStripMenuItem.Name = "suaToolStripMenuItem";
            this.suaToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.suaToolStripMenuItem.Text = "Sửa";
            // 
            // ChiTietToolStripMenuItem
            // 
            this.ChiTietToolStripMenuItem.Name = "ChiTietToolStripMenuItem";
            this.ChiTietToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.ChiTietToolStripMenuItem.Text = "Chi tiết";
            // 
            // tlb_Members
            // 
            this.tlb_Members.ColumnCount = 1;
            this.tlb_Members.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.375F));
            this.tlb_Members.Controls.Add(this.dgv_Members, 0, 1);
            this.tlb_Members.Controls.Add(this.groupBox1, 0, 0);
            this.tlb_Members.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlb_Members.Location = new System.Drawing.Point(0, 0);
            this.tlb_Members.Name = "tlb_Members";
            this.tlb_Members.RowCount = 2;
            this.tlb_Members.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tlb_Members.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.77778F));
            this.tlb_Members.Size = new System.Drawing.Size(1628, 920);
            this.tlb_Members.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tlr_Function);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_SearchMember);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1622, 198);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // tlr_Function
            // 
            this.tlr_Function.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tlr_Function.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AddMember});
            this.tlr_Function.Location = new System.Drawing.Point(3, 18);
            this.tlr_Function.Name = "tlr_Function";
            this.tlr_Function.Size = new System.Drawing.Size(1616, 31);
            this.tlr_Function.TabIndex = 5;
            this.tlr_Function.Text = "toolStrip1";
            // 
            // btn_AddMember
            // 
            this.btn_AddMember.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddMember.Image")));
            this.btn_AddMember.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AddMember.Name = "btn_AddMember";
            this.btn_AddMember.Size = new System.Drawing.Size(70, 28);
            this.btn_AddMember.Text = "Thêm";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1628, 920);
            this.Controls.Add(this.tlb_Members);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Members)).EndInit();
            this.ctt_SubFunctionMember.ResumeLayout(false);
            this.tlb_Members.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tlr_Function.ResumeLayout(false);
            this.tlr_Function.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_SearchMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_Members;
        private System.Windows.Forms.TableLayoutPanel tlb_Members;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip ctt_SubFunctionMember;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ChiTietToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MaHoiVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_HoVaTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TinhTrangGoi;
        private System.Windows.Forms.ToolStrip tlr_Function;
        private System.Windows.Forms.ToolStripButton btn_AddMember;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}