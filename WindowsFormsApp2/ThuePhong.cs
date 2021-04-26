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
    public partial class ThuePhong : Form
    {
        string strConnectionString = "Data Source=DESKTOP-QEEAF23\\SQLEXPRESS; Initial Catalog=quanlikhachsan;Integrated Security=True";
        SqlConnection conn;// = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        public ThuePhong()
        {
            
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            try
            {
                
                string a = this.txtphong.Text.ToString();
                string b = this.txtkh.Text.ToString();
                string c = this.txtdc.Text.ToString();
                string d = this.txtsdt.Text.ToString();
                string h = this.txtnv.Text.ToString();
                string f = this.txtsno.Text.ToString();
                int sno = System.Convert.ToInt32(f);
                string g = this.txtdcoc.Text.ToString();
                int i = System.Convert.ToInt32(g);
                string m = this.txtmt.Text.ToString();
                string n = this.txtmkh.Text.ToString();

                string sql = string.Format("select MaPhong from Phong Where TenPhong='{0}'",a);
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.ExecuteNonQuery();
                string j = cmd.ExecuteScalar().ToString();

                string sql1 = string.Format("insert into KhachHang(MaKhachHang,TenKhachHang,DiaChi,SoDienThoai) values ('{0}' , '{1}' , '{2}' , '{3}' )",n, b , c , d) ;
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                cmd1.ExecuteNonQuery();

                //string sql2 = string.Format("select MaKhachHang as mkh into mytable from KhachHang Where TenKhachHang='{0}'", b);
                //SqlCommand cmd2 = new SqlCommand(sql2, conn);
                //cmd2.ExecuteNonQuery();

                string sql3 = string.Format("insert into ThuePhong values ({0}, '{1}', '{2}', '{3}', {4}, {5})",m,n,j,h,sno,i);
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                cmd3.ExecuteNonQuery();

                string sql4 = string.Format("update Phong set TrangThai = 'Co nguoi o' where MaPhong = '{0}'",j);
                SqlCommand cmd4 = new SqlCommand(sql4, conn);
                cmd4.ExecuteNonQuery();
                
                MessageBox.Show("ok !!!!");
                BangChon z = new BangChon();
                this.Hide();
                z.ShowDialog();
                
            }
            catch
            {
                MessageBox.Show("no no no !!!!");
                BangChon z = new BangChon();
                this.Hide();
                z.ShowDialog();
            }

        }

        private void txtphong_TextChanged(object sender, EventArgs e)
        {

        }

        private void ThuePhong_Load(object sender, EventArgs e)
        {

        }

        private void btncc_Click(object sender, EventArgs e)
        {
            XemPhong f = new XemPhong();
            this.Hide();
            f.ShowDialog();
        }
    }
}
