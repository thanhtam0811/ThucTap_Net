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
    public partial class nhanvien : Form
    {
        public nhanvien()
        {
            InitializeComponent();
        }
        private void nhanvien_Load(object sender, EventArgs e)
        {
            getdata();
           
        }
        public void getdata()
        {
            List<model.nhanvien> data = new List<model.nhanvien>();
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();


            string Query = "Select*from Qlnhanvien";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                model.nhanvien obj = new model.nhanvien();
                obj.Manv = (string)rd["manv"];
                obj.tennv = (string)rd["tennv"];
                obj.Gioitinh = (string)rd["gioitinh"];
                obj.Namsinh = (DateTime)rd["namsinh"];
                obj.Diachi = (string)rd["diachi"];
                obj.Sodienthoai = (string)rd["sodienthoai"];
                obj.Email = (string)rd["email"];
                obj.Chucvu = (string)rd["chucvu"];
                obj.Luongcoban = (double)rd["luongcoban"];
                data.Add(obj);
            }
            conn.Close();
            bang.DataSource = data;
        }
        private void btnhuy_Click(object sender, EventArgs e)
        {
            getdata();
            cbcv.Text = "";
            cbgt.Text = "";
            txtma.Text = "";
            txtdc.Text = "";
            txtem.Text = "";
            txtten.Text = "";
            txtsdt.Text = "";
            txtlcb.Text = "";
            txtmatk.Text = "";
            txttentk.Text = "";
            txtsdttk.Text="";
            txtma.Enabled = true;
            btnthem.Enabled = true;
            lb.Text = "";
        }
        bool kiemtranhap()
        {
            if(txtma.Text=="")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập mã nhân viên";
                txtma.Focus();
                return false;
            }
            if (txtten.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập tên nhân viên";
                txtten.Focus();
                return false;
            }
            if (cbgt.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy chọn giới tính";
                cbgt.Focus();
                return false;
            }
            if (cbcv.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy chọn chức vụ";
                cbcv.Focus();
                return false;
            }
            if (txtdc.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập địa chỉ nhân viên";
                txtdc.Focus();
                return false;
            }
            if (txtsdt.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập số điện thoại nhân viên";
                txtsdt.Focus();
                return false;
            }
            if (txtem.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập email nhân viên";
                txtem.Focus();
                return false;
            }
            if (txtlcb.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập lương cơ bản";
                txtlcb.Focus();
                return false;
            }
            return true;
        }
        bool kiemtraid()
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 manv FROM Qlnhanvien where manv='" + txtma.Text + "'";
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
            string sql = "SELECT top 1 email FROM Qlnhanvien where email='" + txtem.Text + "'";
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
            string manv = txtma.Text;
             string tennv = txtten.Text;
             string gt = this.cbgt.GetItemText(this.cbgt.SelectedItem);
             DateTime ns = this.date.Value;
             string dc = txtdc.Text;
             string sdt = txtsdt.Text;
             string email = txtem.Text;
             string cv = this.cbcv.GetItemText(this.cbcv.SelectedItem);
             string lcb = txtlcb.Text;
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
             string Query = "Insert into Qlnhanvien(manv,tennv,gioitinh,namsinh,diachi,sodienthoai,email,chucvu,luongcoban) Values ('" + manv + "',N'" + tennv + "', N'" + gt + "', '" + ns + "', N'" + dc + "', '" + sdt + "', N'" + email + "',N'" + cv + "','" + lcb + "')";
             SqlCommand cmd = new SqlCommand(Query, conn);              
             int s1 = cmd.ExecuteNonQuery();
            if (s1 == 1)
             {
                
                 lb.ForeColor = Color.Blue;
                 lb.Text = "Thêm thành công";
                getdata();
             }
             else
             {
                 lb.ForeColor = Color.Red;
                 lb.Text = "Thêm thất bại";
             }

            conn.Close();
        }

        private void bang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                // DataGridViewRow row = this.bang.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtma.Text = bang.Rows[row].Cells["Manv"].Value.ToString();
                txtten.Text = bang.Rows[row].Cells["tennv"].Value.ToString();
                cbgt.Text = bang.Rows[row].Cells["Gioitinh"].Value.ToString();
                date.Text = bang.Rows[row].Cells["Namsinh"].Value.ToString();
                txtdc.Text = bang.Rows[row].Cells["Diachi"].Value.ToString();
                txtsdt.Text = bang.Rows[row].Cells["Sodienthoai"].Value.ToString();
                txtem.Text = bang.Rows[row].Cells["Email"].Value.ToString();
                cbcv.Text = bang.Rows[row].Cells["Chucvu"].Value.ToString();
                txtlcb.Text = bang.Rows[row].Cells["Luongcoban"].Value.ToString();
            }
            btnthem.Enabled = false;
            txtma.Enabled = false;


        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            if (txtma.Text == "")
            {
                lb.Text = "Hãy nhập mã nhân viên ";
                lb.ForeColor = Color.Red;
                return;
            }
            string manv = txtma.Text;
            string tennv = txtten.Text;
            string gt = this.cbgt.GetItemText(this.cbgt.SelectedItem);
            DateTime ns = this.date.Value;
            string dc = txtdc.Text;
            string sdt = txtsdt.Text;
            string email = txtem.Text;
            string cv = this.cbcv.GetItemText(this.cbcv.SelectedItem);
            string lcb = txtlcb.Text;
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
            string Query = $"Update Qlnhanvien set  tennv=N'" + tennv + "',gioitinh='" + gt+"' , namsinh='"+ns+"' , diachi=N'"+dc+"' , sodienthoai='"+sdt+"' , email=N'"+email+"', chucvu=N'"+cv+"', luongcoban='"+lcb+"'  where manv=N'"+manv+"'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int s1 = cmd.ExecuteNonQuery();
            if (s1 == 1)
            {
                lb.ForeColor = Color.Blue;
                lb.Text = "Sửa thành công";
                getdata();
            }
            else
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Sữa thất bại";
            }

            conn.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            if (txtma.Text == "")
            {
                lb.Text = "Hãy nhập mã nhân viên ";
                lb.ForeColor = Color.Red;
                return;
            }
            string manv = txtma.Text;
            string Query = $"Delete from Qlnhanvien where manv='" + manv+ "'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int s1 = cmd.ExecuteNonQuery();
            if (s1 == 1)
            {
                lb.ForeColor = Color.Blue;
                lb.Text = "Xoá thành công";
                getdata();
            }
            else
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Xoá thất bại";
            }

            conn.Close();
        }
        private void btnmatk_Click(object sender, EventArgs e)
        {

            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "select * from Qlnhanvien where manv='" + txtmatk.Text + "'";
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
        private void btnsdttk_Click(object sender, EventArgs e)
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "select * from Qlnhanvien where sodienthoai='" + txtsdttk.Text + "'";
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

        private void btntentk_Click(object sender, EventArgs e)
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "select * from Qlnhanvien where tennv='" + txttentk.Text + "'";
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bang_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
