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
using System.Text.RegularExpressions;

namespace Phần_mềm_quản_lý_cửa_hàng_xe_máy
{
    public partial class dangki : Form
    {
        public dangki()
        {
            InitializeComponent();
            lb.Text = "";
        }
        public bool checkAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-z0-9]{6,15}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)");
        }
        bool kiemtraemail()
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 email FROM login where email='" + txtemaildk.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Email đã đăng kí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            conn.Close();
            return true;
        }
        bool kiemtratentk()
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 taikhoan FROM login where taikhoan='" + txttkdk.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Tên tài khoản đã đăng kí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            conn.Close();
            return true;
        }
        SqlConnection cn = new SqlConnection(@"Data Source = DATNGUYEN\SQLEXPRESS; INitial Catalog = QuanLyXeMay; Integrated Security = SSPI");
        private void btndk_Click(object sender, EventArgs e)
        {
            string con_tr = "Data Source=DATNGUYEN\\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            
            if (txttkdk.Text == ("") || txtmkdk.Text == ("") || txtxndk.Text == ("") || txtemaildk.Text == (""))
            {
                txttkdk.Focus();
                txtmkdk.Focus();
                txtxndk.Focus();
                txtemaildk.Focus();
                lb.ForeColor = Color.Red;
                lb.Text = "Yêu cầu nhập đủ thông tin";
            }
            else if (txtmkdk.Text != txtxndk.Text)
            {
                lb.ForeColor = Color.Red;
                lb.Text="Mật khẩu xác nhận không trùng khớp";
            }
            else
            {

                string taikhoan = txttkdk.Text;
                string matkhau = txttkdk.Text;
                string email = txtemaildk.Text;
                if (!checkAccount(taikhoan)) {
                    lb.ForeColor = Color.Red;
                    lb.Text = "Tài khoản phải đủ từ 6-15 kí tự và bao gồm các chữ cái từ a-z";
                    return;
                }
                if (!CheckEmail(email)) {
                    lb.ForeColor = Color.Red;
                    lb.Text = "Email không đúng định dạng";
                    return;
                }
                if (!kiemtraemail())
                {
                    
                    return;
                }
                if (!kiemtratentk())
                {
                   
                    return;
                }
                string Query = $"INSERT INTO login(taikhoan,matkhau,email,quyen) VALUES('{taikhoan}', '{matkhau}','{email}','nhanvien')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                int s = cmd.ExecuteNonQuery();
                if (s == 1)
                {
                    lb.ForeColor = Color.Blue;
                    lb.Text = "Đăng kí thành công";
                }
                else
                {
                    lb.ForeColor = Color.Red;
                    lb.Text = "Đăng kí thất bại";
                }
            }
            conn.Close();
            
        }

        private void lbdn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            dangnhap form2 = new dangnhap();
            form2.ShowDialog();
            this.Close();
        }

        private void dangki_Load(object sender, EventArgs e)
        {

        }
    }
}
