
namespace WindowsFormsApp2
{
    partial class DichVu
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
            this.dgvDichVu = new System.Windows.Forms.DataGridView();
            this.MaDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthemdv = new System.Windows.Forms.Button();
            this.btntrv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDichVu
            // 
            this.dgvDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDichVu,
            this.TenDichVu,
            this.GiaTien});
            this.dgvDichVu.Location = new System.Drawing.Point(50, 49);
            this.dgvDichVu.Name = "dgvDichVu";
            this.dgvDichVu.Size = new System.Drawing.Size(343, 134);
            this.dgvDichVu.TabIndex = 0;
            // 
            // MaDichVu
            // 
            this.MaDichVu.DataPropertyName = "MaDichVu";
            this.MaDichVu.HeaderText = "Mã Dịch vụ";
            this.MaDichVu.Name = "MaDichVu";
            // 
            // TenDichVu
            // 
            this.TenDichVu.DataPropertyName = "TenDichVu";
            this.TenDichVu.HeaderText = "Tên Dịch vụ";
            this.TenDichVu.Name = "TenDichVu";
            // 
            // GiaTien
            // 
            this.GiaTien.DataPropertyName = "GiaTien";
            this.GiaTien.HeaderText = "Giá tiền (vnd)";
            this.GiaTien.Name = "GiaTien";
            // 
            // btnthemdv
            // 
            this.btnthemdv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemdv.Location = new System.Drawing.Point(50, 230);
            this.btnthemdv.Name = "btnthemdv";
            this.btnthemdv.Size = new System.Drawing.Size(90, 33);
            this.btnthemdv.TabIndex = 1;
            this.btnthemdv.Text = "Thêm DV";
            this.btnthemdv.UseVisualStyleBackColor = true;
            this.btnthemdv.Click += new System.EventHandler(this.btnthemdv_Click);
            // 
            // btntrv
            // 
            this.btntrv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrv.Location = new System.Drawing.Point(303, 230);
            this.btntrv.Name = "btntrv";
            this.btntrv.Size = new System.Drawing.Size(90, 33);
            this.btntrv.TabIndex = 2;
            this.btntrv.Text = "Trở về";
            this.btntrv.UseVisualStyleBackColor = true;
            this.btntrv.Click += new System.EventHandler(this.btntrv_Click);
            // 
            // DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 305);
            this.Controls.Add(this.btntrv);
            this.Controls.Add(this.btnthemdv);
            this.Controls.Add(this.dgvDichVu);
            this.Name = "DichVu";
            this.Text = "Dịch Vụ";
            this.Load += new System.EventHandler(this.DichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDichVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.Button btnthemdv;
        private System.Windows.Forms.Button btntrv;
    }
}