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
    public partial class ThemDichVu : Form
    {
        string strConnectionString = "Data Source=DESKTOP-QEEAF23\\SQLEXPRESS; Initial Catalog=quanlikhachsan;Integrated Security=True";
        SqlConnection conn;// = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        public ThemDichVu()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVe_Click(object sender, EventArgs e)
        {
            DichVu f = new DichVu();
            this.Hide();
            f.ShowDialog();
        }

        private void btnThemdv_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            try
            {
                string masd = this.txtMaSD.Text.ToString();
                string madv = this.txtMaDV.Text.ToString();
                string mathue = this.txtMaThue.Text.ToString();
                string ngaysd = this.txtNgaySD.Text.ToString();
                string soluong = this.txtSL.Text.ToString();
                int sl = System.Convert.ToInt32(soluong);

                string sql = string.Format("select GiaTien from DichVu Where MaDichVu='{0}'", madv);
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();
                string j = cmd.ExecuteScalar().ToString();
                int t = System.Convert.ToInt32(j);
                int tt = t * sl;

                string sql1 = string.Format("insert into SuDungDichVu values ('{0}' , '{1}' , '{2}' , '{3}' , {4} )",masd, mathue, madv, ngaysd, tt);
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("OK!");
                ThemDichVu f = new ThemDichVu();
                this.Hide();
                f.ShowDialog();
            }
            catch
            {
                MessageBox.Show("no no no!!!");
            }
        }

        private void txtDG_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            conn.Open();

            string madv = this.txtMaDV.Text.ToString();
            string soluong = this.txtSL.Text.ToString();
            int sl = System.Convert.ToInt32(soluong);
            string sql = string.Format("select GiaTien from DichVu Where MaDichVu='{0}'", madv);
            SqlCommand cmd = new SqlCommand(sql, conn);
            //cmd.ExecuteNonQuery();
            string j = cmd.ExecuteScalar().ToString();
            int t = System.Convert.ToInt32(j);
            int tt = t * sl;
            string ttt = System.Convert.ToString(tt);
            this.txtDG.Text = ttt;
        }

        private void txtMaDV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
