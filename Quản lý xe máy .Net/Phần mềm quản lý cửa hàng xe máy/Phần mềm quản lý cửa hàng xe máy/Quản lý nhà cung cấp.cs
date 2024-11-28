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
    public partial class nhacungcap : Form
    {
        public nhacungcap()
        {
            InitializeComponent();
        }

        private void nhacungcap_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            List<model.nhacungcap> data = new List<model.nhacungcap>();
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();

            string Query = "Select*from Qlnhacungcap";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {

                model.nhacungcap obj = new model.nhacungcap();
                obj.Mancc = (string)rd["mancc"];
                obj.Tenncc = (string)rd["tenncc"];
                obj.Diachincc = (string)rd["diachincc"];
                obj.Sodienthoaincc = (string)rd["sodienthoaincc"];
                obj.Emailncc = (string)rd["emailncc"];


                data.Add(obj);
            }
            conn.Close();
            bang.DataSource = data;
        }
        bool kiemtranhap()
        {
            if (txtmancc.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập mã nhà cung cấp";
                txtmancc.Focus();
                return false;
            }
            if (txttenncc.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập tên nhà cung cấp";
                txttenncc.Focus();
                return false;
            }
            if (txtdcncc.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập địa chỉ nhà cung cấp";
                txtdcncc.Focus();
                return false;
            }
            if (txtsdtncc.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập số điẹn thoại nhà cung cấp";
                txtsdtncc.Focus();
                return false;
            }
            if (txtmailncc.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập email nhà cung cấp";
                txtmailncc.Focus();
                return false;
            }
            
            return true;
        }
        bool kiemtraid()
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 mancc FROM Qlnhacungcap where mancc='" + txtmancc.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Mã hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            conn.Close();
            return true;
        }
        bool kiemtraemail()
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 emailncc FROM Qlnhacungcap where emailncc='" + txtmailncc.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Email đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            conn.Close();
            return true;
        }
        public bool checksdt(string ac)
        {
            return Regex.IsMatch(ac, @"^\d{9,11}$");
        }
        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {

            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            if (!kiemtranhap())
            {
                return;
            }
            if (!kiemtraid())
            {
                return;
            }
            if (!kiemtraemail())
            {
                return;
            }
            string mancc = txtmancc.Text;
            string tenncc = txttenncc.Text;
            string dc = txtdcncc.Text;
            string sdt = txtsdtncc.Text;
            string email = txtmailncc.Text;
            if (!checksdt(sdt))
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Số điện thoại của bạn phải là số và từ 9-11 kí tự";
                return;
            }
            if (!CheckEmail(email))
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Email không đúng định dạng";
                return;
            }
            string Query = "Insert into Qlnhacungcap(mancc,tenncc,diachincc,sodienthoaincc,emailncc) Values ('" + mancc + "',N'" + tenncc + "', N'" + dc + "', '" + sdt + "', '" + email + "')";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int s1 = cmd.ExecuteNonQuery();
            if (s1 == 1)
            {

                lb.ForeColor = Color.Blue;
                lb.Text = "Thêm thành công";
                getData();
            }
            else
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Thêm thất bại";
            }

            conn.Close();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            if (txtmancc.Text == "")
            {
                lb.Text = "Hãy nhập mã nhà cung cấp ";
                lb.ForeColor = Color.Red;
                return;
            }
            string mancc = txtmancc.Text;
            string tenncc = txttenncc.Text;
            string dc = txtdcncc.Text;
            string sdt = txtsdtncc.Text;
            string email = txtmailncc.Text;
            if (!checksdt(sdt))
            { 
                lb.ForeColor = Color.Red;
                lb.Text = "Số điện thoại của bạn phải là số và từ 9-11 kí tự";
                return;
            }
            if (!CheckEmail(email))
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Email không đúng định dạng";
                return;
            }
            string Query = $"Update Qlnhacungcap set tenncc=N'"+tenncc+"',diachincc=N'" + dc + "' , sodienthoaincc='" + sdt + "' , emailncc=N'" + email + "'   where mancc='" + mancc + "'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int s1 = cmd.ExecuteNonQuery();
            if (s1 == 1)
            {

                lb.ForeColor = Color.Blue;
                lb.Text = "Sửa thành công";
                getData();
            }
            else
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Sửa thất bại";
            }

            conn.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            if (txtmancc.Text == "")
            {
                lb.Text = "Hãy nhập mã nhà cung cấp ";
                lb.ForeColor = Color.Red;
                return;
            }

            string mancc = txtmancc.Text;
            string Query = $"Delete from Qlnhacungcap where mancc=" + mancc + "";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int s1 = cmd.ExecuteNonQuery();
            if (s1 == 1)
            {
                lb.ForeColor = Color.Blue;
                lb.Text = "Xoá thành công";
                getData();
            }
            else
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Xoá thất bại";
            }

            conn.Close();
        }

        private void bang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.bang.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtmancc.Text = row.Cells[0].Value.ToString();
                txttenncc.Text = row.Cells[1].Value.ToString();
                txtdcncc.Text = row.Cells[2].Value.ToString();
                txtsdtncc.Text = row.Cells[3].Value.ToString();
                txtmailncc.Text = row.Cells[4].Value.ToString();
                
            }
            btnthem.Enabled = false;
            txtmancc.Enabled = false;
           
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            getData();
            txtmancc.Text = "";
            txttenncc.Text = "";
            txtdcncc.Text = "";
            txtsdtncc.Text = "";
            txtmailncc.Text = "";
            txttenncctk.Text = "";
            txtmancctk.Text = "";
            
            txtmancc.Enabled = true;
            btnthem.Enabled = true;
            lb.Text = "";
        }

        private void btnmancctk_Click(object sender, EventArgs e)
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "select * from Qlnhacungcap where mancc='" + txtmancctk.Text + "'";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            bang.DataSource = dt;
            if (bang.Rows[0].Cells[0].Value == null)
            {
                lb.Text = "Không có thông tin";
            }
            else
            {
                lb.Text = "Tìm thành công";
            }
        }

        private void btntenncctk_Click(object sender, EventArgs e)
        {

            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "select * from Qlnhacungcap where tenncc='" + txttenncctk.Text + "'";
            SqlCommand com = new SqlCommand(sql, conn);
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            bang.DataSource = dt;
            if (bang.Rows[0].Cells[0].Value == null)
            {
                lb.Text = "Không có thông tin";
            }
            else
            {
                lb.Text = "Tìm thành công";
            }
        }

        private void bang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
