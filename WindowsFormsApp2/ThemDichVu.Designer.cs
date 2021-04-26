
namespace WindowsFormsApp2
{
    partial class ThemDichVu
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.txtMaThue = new System.Windows.Forms.TextBox();
            this.txtNgaySD = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtDG = new System.Windows.Forms.TextBox();
            this.btnThemdv = new System.Windows.Forms.Button();
            this.btnVe = new System.Windows.Forms.Button();
            this.btnTinh = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaSD = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Dịch vụ:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã thuê:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sử dụng:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Đơn giá:";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDV.Location = new System.Drawing.Point(220, 88);
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(100, 26);
            this.txtMaDV.TabIndex = 5;
            this.txtMaDV.TextChanged += new System.EventHandler(this.txtMaDV_TextChanged);
            // 
            // txtMaThue
            // 
            this.txtMaThue.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaThue.Location = new System.Drawing.Point(220, 140);
            this.txtMaThue.Name = "txtMaThue";
            this.txtMaThue.Size = new System.Drawing.Size(100, 26);
            this.txtMaThue.TabIndex = 6;
            // 
            // txtNgaySD
            // 
            this.txtNgaySD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgaySD.Location = new System.Drawing.Point(220, 198);
            this.txtNgaySD.Name = "txtNgaySD";
            this.txtNgaySD.Size = new System.Drawing.Size(100, 26);
            this.txtNgaySD.TabIndex = 7;
            // 
            // txtSL
            // 
            this.txtSL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(220, 254);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 26);
            this.txtSL.TabIndex = 8;
            this.txtSL.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtDG
            // 
            this.txtDG.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDG.Location = new System.Drawing.Point(220, 302);
            this.txtDG.Name = "txtDG";
            this.txtDG.Size = new System.Drawing.Size(100, 26);
            this.txtDG.TabIndex = 9;
            this.txtDG.TextChanged += new System.EventHandler(this.txtDG_TextChanged);
            // 
            // btnThemdv
            // 
            this.btnThemdv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemdv.Location = new System.Drawing.Point(53, 361);
            this.btnThemdv.Name = "btnThemdv";
            this.btnThemdv.Size = new System.Drawing.Size(75, 29);
            this.btnThemdv.TabIndex = 10;
            this.btnThemdv.Text = "Thêm";
            this.btnThemdv.UseVisualStyleBackColor = true;
            this.btnThemdv.Click += new System.EventHandler(this.btnThemdv_Click);
            // 
            // btnVe
            // 
            this.btnVe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVe.Location = new System.Drawing.Point(245, 361);
            this.btnVe.Name = "btnVe";
            this.btnVe.Size = new System.Drawing.Size(75, 29);
            this.btnVe.TabIndex = 11;
            this.btnVe.Text = "Quay lại";
            this.btnVe.UseVisualStyleBackColor = true;
            this.btnVe.Click += new System.EventHandler(this.btnVe_Click);
            // 
            // btnTinh
            // 
            this.btnTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinh.Location = new System.Drawing.Point(152, 361);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 29);
            this.btnTinh.TabIndex = 12;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mã Sử dụng:";
            // 
            // txtMaSD
            // 
            this.txtMaSD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSD.Location = new System.Drawing.Point(220, 33);
            this.txtMaSD.Name = "txtMaSD";
            this.txtMaSD.Size = new System.Drawing.Size(100, 26);
            this.txtMaSD.TabIndex = 14;
            // 
            // ThemDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 415);
            this.Controls.Add(this.txtMaSD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.btnVe);
            this.Controls.Add(this.btnThemdv);
            this.Controls.Add(this.txtDG);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtNgaySD);
            this.Controls.Add(this.txtMaThue);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ThemDichVu";
            this.Text = "Thêm Dịch Vụ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.TextBox txtMaThue;
        private System.Windows.Forms.TextBox txtNgaySD;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.Button btnThemdv;
        private System.Windows.Forms.Button btnVe;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaSD;
    }
}