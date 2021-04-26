using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class BangChon : Form
    {
        public BangChon()
        {
            InitializeComponent();
        }

        private void BangChon_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DangNhap f = new DangNhap();
            this.Hide();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XemPhong f = new XemPhong();
            this.Hide();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KhachHang f = new KhachHang();
            this.Hide();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DichVu f = new DichVu();
            this.Hide();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThanhToan f = new ThanhToan();
            this.Hide();
            f.ShowDialog();
        }
    }
}
