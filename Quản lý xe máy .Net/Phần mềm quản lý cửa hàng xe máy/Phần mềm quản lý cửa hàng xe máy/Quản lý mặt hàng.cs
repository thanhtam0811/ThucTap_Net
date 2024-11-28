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
    public partial class xemay : Form
    {
        public xemay()
        {
            InitializeComponent();
        }

        private void xemay_Load(object sender, EventArgs e)
        {
            getData();
        }
        public void getData()
        {
            List<model.xemay> data = new List<model.xemay>();
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();

            string Query = "Select*from Qlhanghoa";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {

                model.xemay obj = new model.xemay();
                obj.Mahang = (string)rd["mahang"];
                obj.Tenhang = (string)rd["tenhang"];
                obj.Nhasanxuat = (string)rd["nhasanxuat"];
                obj.Mota= (string)rd["mota"];
                obj.Soluong = (int)rd["soluong"];
                obj.Giaban = (double)rd["giaban"];           
                obj.Donvitinh = (string)rd["donvitinh"];
               
                obj.Baohanh = (string)rd["baohanh"];
                data.Add(obj);
            }
            conn.Close();
            bang.DataSource = data;
        }
        bool kiemtraid()
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 mahang FROM Qlhanghoa where mahang='" + txtmahang.Text + "'";
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
        bool kiemtratenhang()
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 tenhang FROM Qlhanghoa where tenhang='" + txttenhang.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Tên hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            conn.Close();
            return true;
        }
        bool kiemtranhap()
        {
            if (txtmahang.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập mã hàng";
                txtmahang.Focus();
                return false;
            }
            if (txttenhang.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập tên hàng";
                txttenhang.Focus();
                return false;
            }
            if (txtnsx.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập nhà sản xuất";
                txtnsx.Focus();
                return false;
            }
            if (txtmau.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập màu sắc";
                txtmau.Focus();
                return false;
            }
            if (txtgia.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập giá xe";
                txtgia.Focus();
                return false;
            }
           
            if (txtbh.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập đơn vị tính";
                txtbh.Focus();
                return false;
            }
            if (txtdvt.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập bảo hành";
                txtdvt.Focus();
                return false;
            }
            
            return true;
        }
       


        private void btnthem_Click(object sender, EventArgs e)
        {
            if (!kiemtranhap())
            {
                return;
            }
            if(!kiemtraid())
            {
                return;
            }
            if(!kiemtratenhang())
            {
                return;
            }
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
                string mahang = txtmahang.Text;
                string tenhang = txttenhang.Text;
                string nhasanxuat = txtnsx.Text;
                string mota = txtmau.Text;
                string giaban = txtgia.Text;
                //string soluong = txtsl.Text;
                string baohanh = txtbh.Text;
                string donvitinh = txtdvt.Text;

                string Query = $"Insert into Qlhanghoa(mahang,tenhang,nhasanxuat,mota,soluong,giaban,donvitinh,baohanh) Values ('" + mahang + "',N'" + tenhang + "', N'" + nhasanxuat + "', N'" + mota + "',0, '" + giaban + "', N'" + donvitinh + "', N'" + baohanh + "')";
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

    
        private void bang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.bang.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtmahang.Text = row.Cells[0].Value.ToString();
                txttenhang.Text = row.Cells[1].Value.ToString();
                txtnsx.Text = row.Cells[2].Value.ToString();
                txtmau.Text = row.Cells[3].Value.ToString();
                txtgia.Text = row.Cells[5].Value.ToString();
                txtdvt.Text = row.Cells[6].Value.ToString();
               // txtsl.Text = row.Cells[4].Value.ToString();
                txtbh.Text = row.Cells[7].Value.ToString();
            }
            btnthem.Enabled = false;
            txtmahang.Enabled = false;
            
        }

        private void bang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            getData();
            txtmahang.Text = "";
            txttenhang.Text = "";
            txtnsx.Text = "";
            txtmau.Text = "";
            txtgia.Text = "";
            
            txtdvt.Text = "";
            txtbh.Text = "";
            txtmahang.Enabled = true;
            btnthem.Enabled = true;
            lb.Text = "";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            if (txtmahang.Text == "")
            {
                lb.Text = "Hãy nhập mã hàng ";
                lb.ForeColor = Color.Red;
                return;
            }
            txtmahang.Enabled = false;
            string mahang = txtmahang.Text;
            string tenhang = txttenhang.Text;
            string nhasanxuat = txtnsx.Text;
            string mota = txtmau.Text;
            string giaban = txtgia.Text;
            //string soluong = txtsl.Text;
            string baohanh = txtbh.Text;
            string donvitinh = txtdvt.Text;
            string Query = $"Update Qlhanghoa set tenhang=N'" + tenhang + "',nhasanxuat=N'" + nhasanxuat + "', mota=N'" + mota + "', giaban='" + giaban + "', donvitinh=N'" + donvitinh + "' ,baohanh=N'" + baohanh + "'  where mahang=N'" + mahang + "'";
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
                lb.Text = "Vui lòng kiểm tra lại tên hàng";
            }

            conn.Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            if (txttenhang.Text == "")
            {
                lb.Text = "Hãy nhập tên hàng ";
                lb.ForeColor = Color.Red;
                return;
            }
            
            string tenhang = txttenhang.Text;
           
            string Query = $"Delete from Qlhanghoa where tenhang=N'" + tenhang + "'";
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


        private void btnnsxtk_Click(object sender, EventArgs e)
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "select * from Qlhanghoa where nhasanxuat='" + txtnsxtk.Text + "'";
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

        private void btnmaloaixetk_Click(object sender, EventArgs e)
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "select * from Qlhanghoa where mahang='" +txtmaloaixetk.Text + "'";
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

        private void btntenloaixek_Click(object sender, EventArgs e)
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "select * from Qlhanghoa where tenhang='" + txttenloaixetk.Text + "'";
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
       
      
    }
}
