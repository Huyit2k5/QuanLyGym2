namespace QuanLyGym.Forms.Components
{
    partial class frmDangKyGoiTap
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
            this.txt_HoVaTen = new System.Windows.Forms.TextBox();
            this.txt_TinhTrang = new System.Windows.Forms.TextBox();
            this.lbltinhtrang = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_Goi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NgayBatDau = new System.Windows.Forms.TextBox();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ và tên";
            // 
            // txt_HoVaTen
            // 
            this.txt_HoVaTen.Location = new System.Drawing.Point(188, 43);
            this.txt_HoVaTen.Name = "txt_HoVaTen";
            this.txt_HoVaTen.Size = new System.Drawing.Size(216, 22);
            this.txt_HoVaTen.TabIndex = 1;
            // 
            // txt_TinhTrang
            // 
            this.txt_TinhTrang.Location = new System.Drawing.Point(188, 98);
            this.txt_TinhTrang.Name = "txt_TinhTrang";
            this.txt_TinhTrang.Size = new System.Drawing.Size(216, 22);
            this.txt_TinhTrang.TabIndex = 3;
            // 
            // lbltinhtrang
            // 
            this.lbltinhtrang.AutoSize = true;
            this.lbltinhtrang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltinhtrang.Location = new System.Drawing.Point(65, 101);
            this.lbltinhtrang.Name = "lbltinhtrang";
            this.lbltinhtrang.Size = new System.Drawing.Size(87, 19);
            this.lbltinhtrang.TabIndex = 4;
            this.lbltinhtrang.Text = "Tình trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gói";
            // 
            // cbo_Goi
            // 
            this.cbo_Goi.FormattingEnabled = true;
            this.cbo_Goi.Location = new System.Drawing.Point(188, 153);
            this.cbo_Goi.Name = "cbo_Goi";
            this.cbo_Goi.Size = new System.Drawing.Size(216, 24);
            this.cbo_Goi.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày bắt đầu";
            // 
            // txt_NgayBatDau
            // 
            this.txt_NgayBatDau.Location = new System.Drawing.Point(188, 210);
            this.txt_NgayBatDau.Name = "txt_NgayBatDau";
            this.txt_NgayBatDau.Size = new System.Drawing.Size(216, 22);
            this.txt_NgayBatDau.TabIndex = 8;
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_XacNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XacNhan.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btn_XacNhan.Location = new System.Drawing.Point(69, 268);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(335, 47);
            this.btn_XacNhan.TabIndex = 60;
            this.btn_XacNhan.Text = "Xác nhận";
            this.btn_XacNhan.UseVisualStyleBackColor = false;
            // 
            // frmDangKyGoiTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.txt_NgayBatDau);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_Goi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltinhtrang);
            this.Controls.Add(this.txt_TinhTrang);
            this.Controls.Add(this.txt_HoVaTen);
            this.Controls.Add(this.label1);
            this.Name = "frmDangKyGoiTap";
            this.Text = "frmDangKyGoiTap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_HoVaTen;
        private System.Windows.Forms.TextBox txt_TinhTrang;
        private System.Windows.Forms.Label lbltinhtrang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_Goi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NgayBatDau;
        private System.Windows.Forms.Button btn_XacNhan;
    }
}