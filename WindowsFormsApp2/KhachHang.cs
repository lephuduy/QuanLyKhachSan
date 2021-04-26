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
    public partial class KhachHang : Form
    {
        string strConnectionString = "Data Source=DESKTOP-QEEAF23\\SQLEXPRESS; Initial Catalog=quanlikhachsan;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            try
            {
                // Khởi động connection
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu lên DataTable dtPhong
                da = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
                dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                // Đưa dữ liệu lên DataGridView
                dgvKH.DataSource = dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Phong. Lỗi rồi!!!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string s = this.txtTim.Text.ToString();
            try
            {
                // Khởi động connection
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu lên DataTable dtPhong
                da = new SqlDataAdapter("SELECT * FROM KhachHang where TenKhachHang=" + "'" + s +"'", conn);
                dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                // Đưa dữ liệu lên DataGridView
                dgvKH.DataSource = dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không có khách hàng này!!!");
            }
        }

        private void btnTL_Click(object sender, EventArgs e)
        {
            BangChon f = new BangChon();
            this.Hide();
            f.ShowDialog();
        }
    }
}
