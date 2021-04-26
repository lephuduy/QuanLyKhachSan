
namespace WindowsFormsApp2
{
    partial class XemPhong
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
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.TenPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthue = new System.Windows.Forms.Button();
            this.btnql1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPhong
            // 
            this.dgvPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPhong,
            this.GiaThue,
            this.TrangThai});
            this.dgvPhong.Location = new System.Drawing.Point(78, 51);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.Size = new System.Drawing.Size(341, 280);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellContentClick);
            // 
            // TenPhong
            // 
            this.TenPhong.DataPropertyName = "TenPhong";
            this.TenPhong.HeaderText = "Phòng";
            this.TenPhong.Name = "TenPhong";
            this.TenPhong.Width = 72;
            // 
            // GiaThue
            // 
            this.GiaThue.DataPropertyName = "GiaThue";
            this.GiaThue.HeaderText = "Giá thuê (vnd/ngày)";
            this.GiaThue.Name = "GiaThue";
            this.GiaThue.Width = 139;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng thái";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 86;
            // 
            // btnthue
            // 
            this.btnthue.Location = new System.Drawing.Point(78, 359);
            this.btnthue.Name = "btnthue";
            this.btnthue.Size = new System.Drawing.Size(75, 30);
            this.btnthue.TabIndex = 1;
            this.btnthue.Text = "Thuê";
            this.btnthue.UseVisualStyleBackColor = true;
            this.btnthue.Click += new System.EventHandler(this.btnthue_Click);
            // 
            // btnql1
            // 
            this.btnql1.Location = new System.Drawing.Point(344, 359);
            this.btnql1.Name = "btnql1";
            this.btnql1.Size = new System.Drawing.Size(75, 30);
            this.btnql1.TabIndex = 2;
            this.btnql1.Text = "Quay lại";
            this.btnql1.UseVisualStyleBackColor = true;
            this.btnql1.Click += new System.EventHandler(this.btnql1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hủy phòng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // XemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 414);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnql1);
            this.Controls.Add(this.btnthue);
            this.Controls.Add(this.dgvPhong);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XemPhong";
            this.Text = "Xem Phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XemPhong_FormClosing);
            this.Load += new System.EventHandler(this.XemPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.Button btnthue;
        private System.Windows.Forms.Button btnql1;
        private System.Windows.Forms.Button button1;
    }
}