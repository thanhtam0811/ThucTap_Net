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
    public partial class doimatkhau : Form
    {
        public doimatkhau()
        {
            InitializeComponent();
        }

        private void txttk_Enter(object sender, EventArgs e)
        {
            if(txttk.Text=="Nhập tài khoản đăng nhập")
            {
                txttk.Text = "";
                txttk.ForeColor = Color.Black;
            }
        }

        private void txttk_Leave(object sender, EventArgs e)
        {
            if (txttk.Text == "")
            {
                txttk.Text = "Nhập tài khoản đăng nhập";
                txttk.ForeColor = Color.White;
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtmk_Enter_1(object sender, EventArgs e)
        {
            if (txtmk.Text == "Nhập mật khẩu cũ")
            {
                txtmk.Text = "";
                txtmk.ForeColor = Color.Black;
            }
        }

        private void txtmk_Leave_1(object sender, EventArgs e)
        {
            if (txtmk.Text == "")
            {
                txtmk.Text = "Nhập mật khẩu cũ";
                txtmk.ForeColor = Color.White;
            }
        }

        private void txtmkm_Enter_1(object sender, EventArgs e)
        {
            if (txtmkm.Text == "Nhập mật khẩu mới")
            {
                txtmkm.Text = "";
                txtmkm.ForeColor = Color.Black;
            }
        }

        private void txtmkm_Leave_1(object sender, EventArgs e)
        {
            if (txtmkm.Text == "")
            {
                txtmkm.Text = "Nhập mật khẩu mới";
                txtmkm.ForeColor = Color.White;
            }
        }
        bool kiemtra()
        {
            if (txttk.Text == "Nhập tài khoản đăng nhập" )
            {
                lb.Text = "Yêu cầu nhập tên tài khoản";
                txttk.Focus();
               
                return false;
            }
            if (txtmk.Text == "Nhập mật khẩu cũ")
            {
                lb.Text = "Yêu cầu nhập mật khẩu cũ";
                txtmk.Focus();

                return false;
            }
            if (txtmkm.Text == "Nhập mật khẩu mới")
            {
                lb.Text = "Yêu cầu nhập mật khẩu mới";
                txtmkm.Focus();

                return false;
            }
            if(txtmkm.Text==txtmk.Text)
            {
                lb.Text = "Yêu cầu mật khẩu mới khác với mật khẩu cũ";
                txtmkm.Focus();
                return false;
            }

            return true;
        }

        SqlConnection cn = new SqlConnection(@"Data Source = DATNGUYEN\SQLEXPRESS; INitial Catalog = QuanLyXeMay; Integrated Security = SSPI");
        private void btndmk_Click(object sender, EventArgs e)
        {
           
            if(!kiemtra())
            {
                return;
            }
           
            cn.Open();
            string sql =" update login set matkhau = N'"+txtmkm.Text+"' where taikhoan = N'"+txttk.Text+"' and matkhau = N'"+txtmk.Text+"'";
            SqlCommand cmd1 = new SqlCommand(sql, cn);
            int i = cmd1.ExecuteNonQuery();
            if (i == 1)
            {
                lb.Text = "Đổi mật khẩu thành công";
                lb.ForeColor = Color.Blue;
               
               
                
               
            }
            else
            {
                lb.Text = "tài khoản hoặc mật khẩu cũ không chính xác";
                lb.ForeColor = Color.Red;
            }
            cn.Close();

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttk_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
