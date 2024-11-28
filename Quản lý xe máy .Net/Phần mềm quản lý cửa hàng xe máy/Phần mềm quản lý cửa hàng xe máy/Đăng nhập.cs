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


namespace Phần_mềm_quản_lý_cửa_hàng_xe_máy
{
    public partial class dangnhap : Form
    {
        int dem;
        public dangnhap()
        {
            InitializeComponent();
            
        }
       
        SqlConnection cn = new SqlConnection(@"Data Source = DATNGUYEN\SQLEXPRESS; INitial Catalog = QuanLyXeMay; Integrated Security = SSPI");
        private void btndn_Click(object sender, EventArgs e)
        {
            
            
            if (txttk.Text == ("") || txtmk.Text == (""))
            {

                txttk.Focus();
                txtmk.Focus();
                lb.ForeColor = Color.Red;
                lb.Text = "Chưa nhập tài khoản hoặc mật khẩu";
                return;
            }
                dem++;
            cn.Open();
            string sql = "select * from login where taikhoan='"+txttk.Text+"'and matkhau='"+txtmk.Text+"'";
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count >0 )
                {
                   
                    lb.ForeColor = Color.Blue;
                    lb.Text = "Đăng nhập thành công";

                
                    this.Hide();
                    
                    trangchu frmtc = new trangchu(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString());
                    frmtc.ShowDialog();
                    this.Close();

                }
                else
                {
                    lb.ForeColor = Color.Red;
                    lb.Text = "Sai tài khoản hoặc mật khẩu";

                }
                if(dem==3)
                {
                    MessageBox.Show("Nhập sai quá 3 lần! Thoát chương trình", "Thông báo"); 
                    Application.Exit();
                }
            cn.Close();
                
            }
           
        
            
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ldk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            dangki frmdk = new dangki();
            frmdk.ShowDialog();
            this.Close();
        }

        private void lqmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            quenmatkhau frmqmk = new quenmatkhau();
            frmqmk.ShowDialog();
            this.Close();
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(txtmk.PasswordChar=='*')
            {
                checkBox1.BringToFront();
                txtmk.PasswordChar = '\0';
            }
            else
            {
                checkBox1.BringToFront();
                txtmk.PasswordChar = '*';
            }
        }
    }
}
