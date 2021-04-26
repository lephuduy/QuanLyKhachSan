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
    public partial class DangNhap : Form
    {
        string strConnectionString = "Data Source=DESKTOP-QEEAF23\\SQLEXPRESS; Initial Catalog=quanlikhachsan;Integrated Security=True";
        SqlConnection conn = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btndn_Click(object sender, EventArgs e)
        {

            conn = new SqlConnection(strConnectionString);
            conn.Open();
            try
            {
                
                string a = this.txtdn.Text.ToString();
                string sql = string.Format("select MatKhau from NhanVien Where MaNhanVien='{0}'", a);
                SqlCommand cmd = new SqlCommand(sql, conn);

                //string sql = "select MatKhau from NhanVien Where MaNhanVien=" + a;
                //SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();

                string j = cmd.ExecuteScalar().ToString();
               // MessageBox.Show(j);
                string s = this.txtmk.Text.ToString();
                if (j == s)
                {
                    
                    BangChon f = new BangChon();
                    this.Hide();
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu!");
                    DangNhap f = new DangNhap();
                    this.Hide();
                    f.ShowDialog();
                }
            }
            catch 
            {
                MessageBox.Show("Sai thông tin tài khoản hoặc mật khẩu!");
                DangNhap f = new DangNhap();
                this.Hide();
                f.ShowDialog();
            }
        }
    }
}
