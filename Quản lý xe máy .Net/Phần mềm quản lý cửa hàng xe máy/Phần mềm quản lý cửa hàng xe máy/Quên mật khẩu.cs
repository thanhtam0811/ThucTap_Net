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
    public partial class quenmatkhau : Form
    {
        public quenmatkhau()
        {
            InitializeComponent();
        }

        private void btnlaymk_Click(object sender, EventArgs e)
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            if (txtemail.Text == ("") )
            {
                txtemail.Focus();
                lb.ForeColor = Color.Red;
                lb.Text = "Nhập email đăng kí";
            }
            
            else
            {

                string email = txtemail.Text;
                
                string Query = $"SELECT *from login Where email='{email}'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    lb.ForeColor = Color.Blue;
                    
                    lb.Text = "Mật khẩu là:" + rd["matkhau"].ToString();
                    
                }
                else
                {
                    lb.ForeColor = Color.Red;
                    lb.Text = "Email không chính xác hoặc chưa đăng kí";
                }
            }
            conn.Close();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            dangnhap form2 = new dangnhap();
            form2.ShowDialog();
            this.Close();
        }
    }
}
