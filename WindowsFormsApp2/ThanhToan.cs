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
    public partial class ThanhToan : Form
    {
        string strConnectionString = "Data Source=DESKTOP-QEEAF23\\SQLEXPRESS; Initial Catalog=quanlikhachsan;Integrated Security=True";
        SqlConnection conn;// = null;
        SqlDataAdapter da = null;
        DataTable dt = null;
        public ThanhToan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            try
            {
                string mathue = this.txtMT.Text.ToString();
                

                string sql = string.Format("select MaPhong from ThuePhong Where MaThue='{0}'", mathue);
                SqlCommand cmd = new SqlCommand(sql, conn);
                string maphong = cmd.ExecuteScalar().ToString();

                string sql2 = string.Format("select TenPhong from Phong Where MaPhong='{0}'", maphong);
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                string tenphong = cmd2.ExecuteScalar().ToString();

                string sql3 = string.Format("select GiaThue from Phong Where MaPhong='{0}'", maphong);
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                string giathue = cmd3.ExecuteScalar().ToString();
                int giathue1 = System.Convert.ToInt32(giathue);

                string sql4 = string.Format("select SoNgayO from ThuePhong Where MaThue='{0}'", mathue);
                SqlCommand cmd4 = new SqlCommand(sql4, conn);
                string sno = cmd4.ExecuteScalar().ToString();
                int sno1 = System.Convert.ToInt32(sno);

                string sql5 = string.Format("select sum(DonGia) from SuDungDichVu Where MaThue='{0}'", mathue);
                SqlCommand cmd5 = new SqlCommand(sql5, conn);
                string dongia = cmd5.ExecuteScalar().ToString();
                int dongia1 = System.Convert.ToInt32(dongia);

                string sql6 = string.Format("select DatCoc from ThuePhong Where MaThue='{0}'", mathue);
                SqlCommand cmd6 = new SqlCommand(sql6, conn);
                string datcoc = cmd6.ExecuteScalar().ToString();
                int datcoc1 = System.Convert.ToInt32(datcoc); 

                string sql7 = string.Format("select MaKhachHang from ThuePhong Where MaThue='{0}'", mathue);
                SqlCommand cmd7 = new SqlCommand(sql7, conn);
                string makh = cmd7.ExecuteScalar().ToString();
                
                
                int tienphong = giathue1 * sno1;
                int thanhtoan = tienphong + dongia1;
                int tienconlai = thanhtoan - datcoc1;

                //this.lbThanhToan.Text 
                this.lbThanhToan.Text = "Mã thuê: " + mathue + "\r\nPhòng: " + tenphong + "\r\nTiền phòng: " + tienphong +"vnd\r\nDịch vụ: " + dongia +  "vnd\r\nĐặt cọc: " +  datcoc1 +"vnd\r\nSố tiền còn lại: " + tienconlai + "vnd";
                //this.lbThanhToan.Text += str;
                //string sql10 = string.Format("insert into SuDungDichVu values ('{0}' , '{1}' , '{2}' , '{3}' , {4} )", masd, mathue, madv, ngaysd, tt);
                //SqlCommand cmd10 = new SqlCommand(sql10, conn);
                //cmd10.ExecuteNonQuery();
                //MessageBox.Show(str);
                //this.Load();
            }
            catch
            {
                MessageBox.Show("không tìm thấy!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(strConnectionString);
            conn.Open();
            try
            {
                string mathue = this.txtMT.Text.ToString();


                string sql = string.Format("select MaPhong from ThuePhong Where MaThue='{0}'", mathue);
                SqlCommand cmd = new SqlCommand(sql, conn);
                string maphong = cmd.ExecuteScalar().ToString();

                string sql2 = string.Format("select TenPhong from Phong Where MaPhong='{0}'", maphong);
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                string tenphong = cmd2.ExecuteScalar().ToString();

                string sql3 = string.Format("select GiaThue from Phong Where MaPhong='{0}'", maphong);
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                string giathue = cmd3.ExecuteScalar().ToString();
                int giathue1 = System.Convert.ToInt32(giathue);

                string sql4 = string.Format("select SoNgayO from ThuePhong Where MaThue='{0}'", mathue);
                SqlCommand cmd4 = new SqlCommand(sql4, conn);
                string sno = cmd4.ExecuteScalar().ToString();
                int sno1 = System.Convert.ToInt32(sno);

                string sql5 = string.Format("select sum(DonGia) from SuDungDichVu Where MaThue='{0}'", mathue);
                SqlCommand cmd5 = new SqlCommand(sql5, conn);
                string dongia = cmd5.ExecuteScalar().ToString();
                int dongia1 = System.Convert.ToInt32(dongia);

                string sql6 = string.Format("select DatCoc from ThuePhong Where MaThue='{0}'", mathue);
                SqlCommand cmd6 = new SqlCommand(sql6, conn);
                string datcoc = cmd6.ExecuteScalar().ToString();
                int datcoc1 = System.Convert.ToInt32(dongia);

                string sql7 = string.Format("select MaKhachHang from ThuePhong Where MaThue='{0}'", mathue);
                SqlCommand cmd7 = new SqlCommand(sql7, conn);
                string makh = cmd7.ExecuteScalar().ToString();


                int tienphong = giathue1 * sno1;
                int thanhtoan = tienphong + dongia1;
                int tienconlai = thanhtoan - datcoc1;

                //this.lbThanhToan.Text 
                //string str = "Mã thuê: " + mathue + "\nPhòng: " + tenphong + "\nTiền phòng: " + tienphong + "\nDịch vụ: " + dongia + "\nSố tiền còn lại: " + tienconlai;
                //this.lbThanhToan.Text += str;

                string ntt = this.txtNTT.Text.ToString();
                string ghichu = this.txtGC.Text.ToString();

                string sql10 = string.Format("insert into ThanhToan(MaThue,ThanhTien,GhiChu,NgayThanhToan) values ('{0}' , {1} , '{2}' , '{3}'  )", mathue, thanhtoan, ntt, ghichu);
                SqlCommand cmd10 = new SqlCommand(sql10, conn);
                cmd10.ExecuteNonQuery();

                string sql11 = string.Format("update Phong set  TrangThai = 'Trong' where MaPhong = '{0}'",maphong);
                SqlCommand cmd11 = new SqlCommand(sql11, conn);
                cmd11.ExecuteNonQuery();


                MessageBox.Show("OK!");
                BangChon f = new BangChon();
                this.Hide();
                f.ShowDialog();
            }
            catch
            {
                MessageBox.Show("no no no!!!");
                ThanhToan f = new ThanhToan();
                this.Hide();
                f.ShowDialog();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ThanhToan_Load(object sender, EventArgs e)
        {

        }

        private void lbThanhToan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            BangChon f = new BangChon();
            this.Hide();
            f.ShowDialog();
        }
    }
}
