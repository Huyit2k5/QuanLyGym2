namespace QuanLyGym.Forms
{
    partial class frmAdmin
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
            this.grb_ChucNang = new System.Windows.Forms.GroupBox();
            this.btn_NhanVien = new System.Windows.Forms.Button();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.grb_ChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.17808F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.82191F));
            this.tableLayoutPanel1.Controls.Add(this.grb_ChucNang, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnl_Main, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.89796F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.10204F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1665, 1007);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // grb_ChucNang
            // 
            this.grb_ChucNang.BackColor = System.Drawing.Color.SteelBlue;
            this.grb_ChucNang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grb_ChucNang.Controls.Add(this.btn_NhanVien);
            this.grb_ChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grb_ChucNang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grb_ChucNang.Location = new System.Drawing.Point(3, 154);
            this.grb_ChucNang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_ChucNang.Name = "grb_ChucNang";
            this.grb_ChucNang.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grb_ChucNang.Size = new System.Drawing.Size(313, 849);
            this.grb_ChucNang.TabIndex = 1;
            this.grb_ChucNang.TabStop = false;
            // 
            // btn_NhanVien
            // 
            this.btn_NhanVien.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_NhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_NhanVien.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_NhanVien.FlatAppearance.BorderSize = 0;
            this.btn_NhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NhanVien.ForeColor = System.Drawing.Color.Transparent;
            this.btn_NhanVien.Location = new System.Drawing.Point(3, 23);
            this.btn_NhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_NhanVien.Name = "btn_NhanVien";
            this.btn_NhanVien.Size = new System.Drawing.Size(307, 108);
            this.btn_NhanVien.TabIndex = 0;
            this.btn_NhanVien.Text = "Nhân viên";
            this.btn_NhanVien.UseVisualStyleBackColor = false;
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.SteelBlue;
            this.pnl_Main.Location = new System.Drawing.Point(322, 154);
            this.pnl_Main.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Size = new System.Drawing.Size(1340, 849);
            this.pnl_Main.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::QuanLyGym.Properties.Resources.LogoHuitGym;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 2);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1659, 142);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 1007);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.grb_ChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox grb_ChucNang;
        private System.Windows.Forms.Button btn_NhanVien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_Main;
    }
}