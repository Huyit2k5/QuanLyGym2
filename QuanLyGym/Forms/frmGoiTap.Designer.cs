namespace QuanLyGym.Forms
{
    partial class frmGoiTap
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
            this.tbp_Goi = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_GoiTap = new System.Windows.Forms.DataGridView();
            this.col_MaGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_TenGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_GiaGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ThoiHanGoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grb_goi = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SearchGoiTap = new System.Windows.Forms.TextBox();
            this.tbp_Goi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GoiTap)).BeginInit();
            this.grb_goi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbp_Goi
            // 
            this.tbp_Goi.ColumnCount = 2;
            this.tbp_Goi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbp_Goi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbp_Goi.Controls.Add(this.dgv_GoiTap, 0, 1);
            this.tbp_Goi.Controls.Add(this.grb_goi, 0, 0);
            this.tbp_Goi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbp_Goi.Location = new System.Drawing.Point(0, 0);
            this.tbp_Goi.Name = "tbp_Goi";
            this.tbp_Goi.RowCount = 2;
            this.tbp_Goi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.13793F));
            this.tbp_Goi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.86207F));
            this.tbp_Goi.Size = new System.Drawing.Size(1625, 866);
            this.tbp_Goi.TabIndex = 0;
            // 
            // dgv_GoiTap
            // 
            this.dgv_GoiTap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GoiTap.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgv_GoiTap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_GoiTap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_MaGoi,
            this.col_TenGoi,
            this.col_GiaGoi,
            this.col_ThoiHanGoi});
            this.tbp_Goi.SetColumnSpan(this.dgv_GoiTap, 2);
            this.dgv_GoiTap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_GoiTap.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_GoiTap.Location = new System.Drawing.Point(3, 212);
            this.dgv_GoiTap.Name = "dgv_GoiTap";
            this.dgv_GoiTap.RowHeadersWidth = 51;
            this.dgv_GoiTap.RowTemplate.Height = 24;
            this.dgv_GoiTap.Size = new System.Drawing.Size(1619, 651);
            this.dgv_GoiTap.TabIndex = 0;
            // 
            // col_MaGoi
            // 
            this.col_MaGoi.DataPropertyName = "MaGoi";
            this.col_MaGoi.HeaderText = "Mã gói";
            this.col_MaGoi.MinimumWidth = 6;
            this.col_MaGoi.Name = "col_MaGoi";
            // 
            // col_TenGoi
            // 
            this.col_TenGoi.DataPropertyName = "TenGoi";
            this.col_TenGoi.HeaderText = "Tên gói";
            this.col_TenGoi.MinimumWidth = 6;
            this.col_TenGoi.Name = "col_TenGoi";
            // 
            // col_GiaGoi
            // 
            this.col_GiaGoi.DataPropertyName = "Gia";
            this.col_GiaGoi.HeaderText = "Giá";
            this.col_GiaGoi.MinimumWidth = 6;
            this.col_GiaGoi.Name = "col_GiaGoi";
            // 
            // col_ThoiHanGoi
            // 
            this.col_ThoiHanGoi.DataPropertyName = "ThoiHan";
            this.col_ThoiHanGoi.HeaderText = "Thời hạn";
            this.col_ThoiHanGoi.MinimumWidth = 6;
            this.col_ThoiHanGoi.Name = "col_ThoiHanGoi";
            // 
            // grb_goi
            // 
            this.tbp_Goi.SetColumnSpan(this.grb_goi, 2);
            this.grb_goi.Controls.Add(this.label2);
            this.grb_goi.Controls.Add(this.label1);
            this.grb_goi.Controls.Add(this.txt_SearchGoiTap);
            this.grb_goi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_goi.Location = new System.Drawing.Point(3, 3);
            this.grb_goi.Name = "grb_goi";
            this.grb_goi.Size = new System.Drawing.Size(1619, 203);
            this.grb_goi.TabIndex = 1;
            this.grb_goi.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(491, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quản lý gói tập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm";
            // 
            // txt_SearchGoiTap
            // 
            this.txt_SearchGoiTap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_SearchGoiTap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_SearchGoiTap.Location = new System.Drawing.Point(137, 98);
            this.txt_SearchGoiTap.Name = "txt_SearchGoiTap";
            this.txt_SearchGoiTap.Size = new System.Drawing.Size(424, 22);
            this.txt_SearchGoiTap.TabIndex = 0;
            // 
            // frmGoiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1625, 866);
            this.Controls.Add(this.tbp_Goi);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGoiTap";
            this.Text = "frmGoiTap";
            this.tbp_Goi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GoiTap)).EndInit();
            this.grb_goi.ResumeLayout(false);
            this.grb_goi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbp_Goi;
        private System.Windows.Forms.DataGridView dgv_GoiTap;
        private System.Windows.Forms.GroupBox grb_goi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SearchGoiTap;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_MaGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_TenGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_GiaGoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ThoiHanGoi;
    }
}