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
    public partial class DichVu : Form
    {
        string strConnectionString = "Data Source=DESKTOP-QEEAF23\\SQLEXPRESS; Initial Catalog=quanlikhachsan;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        public DichVu()
        {
            InitializeComponent();
        }

        private void DichVu_Load(object sender, EventArgs e)
        {
            try
            {
                // Khởi động connection
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu lên DataTable dt
                da = new SqlDataAdapter("SELECT * FROM DichVu", conn);
                dt = new DataTable();
                dt.Clear();
                da.Fill(dt);
                // Đưa dữ liệu lên DataGridView
                dgvDichVu.DataSource = dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table Phong. Lỗi rồi!!!");
            }
        }

        private void btntrv_Click(object sender, EventArgs e)
        {
            BangChon f = new BangChon();
            this.Hide();
            f.ShowDialog();
        }

        private void btnthemdv_Click(object sender, EventArgs e)
        {
            ThemDichVu f = new ThemDichVu();
            this.Hide();
            f.ShowDialog();
        }
    }
}
