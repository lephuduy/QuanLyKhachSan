using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class XemPhong : Form
    {
        string strConnectionString = "Data Source=DESKTOP-QEEAF23\\SQLEXPRESS; Initial Catalog=quanlikhachsan;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter daPhong = null;
        DataTable dtPhong = null;

        public XemPhong()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void XemPhong_Load(object sender, EventArgs e)
        {
            try
            {
                // Khởi động connection
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu lên DataTable dtPhong
                daPhong = new SqlDataAdapter("SELECT TenPhong,GiaThue,TrangThai FROM Phong", conn); 
                dtPhong = new DataTable();
                dtPhong.Clear();
                daPhong.Fill(dtPhong);
                // Đưa dữ liệu lên DataGridView
                dgvPhong.DataSource = dtPhong; 
            }
            catch (SqlException)
            {   
                MessageBox.Show("Không lấy được nội dung trong table Phong. Lỗi rồi!!!"); }
        }

        private void XemPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
            dtPhong.Dispose();
            dtPhong = null;
            conn = null;
        }

        private void btnql1_Click(object sender, EventArgs e)
        {
            conn.Close();
            BangChon f = new BangChon();
            this.Hide();
            f.ShowDialog();
        }

        private void btnthue_Click(object sender, EventArgs e)
        {
            //conn.Close();
            ThuePhong f = new ThuePhong();
            this.Hide();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            int r = dgvPhong.CurrentCell.RowIndex;
            string phong = dgvPhong.Rows[r].Cells[0].Value.ToString();

            string sql = string.Format("select MaPhong from Phong Where TenPhong='{0}'", phong);
            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.ExecuteNonQuery();
            string maphong = cmd.ExecuteScalar().ToString();

            string sql1 = string.Format("update Phong set TrangThai='Trong' Where MaPhong='{0}'", maphong);
            SqlCommand cmd1 = new SqlCommand(sql1, conn);
            cmd1.ExecuteNonQuery();
            //string j = cmd1.ExecuteScalar().ToString();

            MessageBox.Show("OK!!!");
            XemPhong f = new XemPhong();
            this.Hide();
            f.ShowDialog();

        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
