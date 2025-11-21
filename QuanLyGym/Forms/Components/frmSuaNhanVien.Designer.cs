namespace QuanLyGym.Forms.Components
{
    partial class frmSuaNhanVien
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
            this.btn_Luu = new System.Windows.Forms.Button();
            this.cbo_ChucVu = new System.Windows.Forms.ComboBox();
            this.cbo_GioiTinh = new System.Windows.Forms.ComboBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.txt_MaNV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(184, 438);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(145, 40);
            this.btn_Luu.TabIndex = 17;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            // 
            // cbo_ChucVu
            // 
            this.cbo_ChucVu.FormattingEnabled = true;
            this.cbo_ChucVu.Location = new System.Drawing.Point(165, 376);
            this.cbo_ChucVu.Name = "cbo_ChucVu";
            this.cbo_ChucVu.Size = new System.Drawing.Size(252, 28);
            this.cbo_ChucVu.TabIndex = 15;
            // 
            // cbo_GioiTinh
            // 
            this.cbo_GioiTinh.FormattingEnabled = true;
            this.cbo_GioiTinh.Location = new System.Drawing.Point(165, 248);
            this.cbo_GioiTinh.Name = "cbo_GioiTinh";
            this.cbo_GioiTinh.Size = new System.Drawing.Size(252, 28);
            this.cbo_GioiTinh.TabIndex = 16;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(165, 314);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(252, 26);
            this.txt_SDT.TabIndex = 12;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(165, 182);
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(252, 26);
            this.txt_TenNV.TabIndex = 13;
            // 
            // txt_MaNV
            // 
            this.txt_MaNV.Location = new System.Drawing.Point(165, 119);
            this.txt_MaNV.Name = "txt_MaNV";
            this.txt_MaNV.Size = new System.Drawing.Size(252, 26);
            this.txt_MaNV.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "SDT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "ChucVu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "GioiTinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "TenNV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "MaNV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sửa nhân viên";
            // 
            // frmSuaNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 523);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.cbo_ChucVu);
            this.Controls.Add(this.cbo_GioiTinh);
            this.Controls.Add(this.txt_SDT);
            this.Controls.Add(this.txt_TenNV);
            this.Controls.Add(this.txt_MaNV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSuaNhanVien";
            this.Text = "SuaNhanVien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.ComboBox cbo_ChucVu;
        private System.Windows.Forms.ComboBox cbo_GioiTinh;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.TextBox txt_MaNV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}