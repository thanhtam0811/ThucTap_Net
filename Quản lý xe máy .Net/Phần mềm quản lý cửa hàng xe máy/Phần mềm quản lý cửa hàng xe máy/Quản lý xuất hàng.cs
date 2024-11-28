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
    public partial class xuathang : Form
    {
        public xuathang()
        {
            InitializeComponent();
        }
        private void xuathang_Load_1(object sender, EventArgs e)
        {
            txtslkho.Enabled = false;
            txtgiaxuat.Enabled = false;
            getData();
            getDataNV();
            getDataHH();
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
                obj.Giaban = (double)rd["giaban"];
                obj.Mahang = (string)rd["mahang"];
                obj.Soluong = (int)rd["soluong"];
                data.Add(obj);
            }
            conn.Close();
            cbmahang.DataSource = data;
            cbmahang.DisplayMember = "mahang";
            cbmahang.ValueMember = "giaban";
            txtgiaxuat.DataBindings.Clear();
            txtgiaxuat.DataBindings.Add("Text", cbmahang.DataSource, "giaban");


            cbmahang.ValueMember = "soluong";
            txtslkho.DataBindings.Clear();
            txtslkho.DataBindings.Add("Text", cbmahang.DataSource, "soluong");
        }
        public void getDataNV()
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
                obj.tennv = (string)rd["tennv"];
                data.Add(obj);
            }
            conn.Close();
            cbnv.DataSource = data;
            cbnv.DisplayMember = "tennv";
            cbnv.ValueMember = "tennv";

        }
        public void getDataHH()
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
                data.Add(obj);
            }
            conn.Close();
            cbmahang.DataSource = data;
            cbmahang.DisplayMember = "mahang";
            cbmahang.ValueMember = "mahang";
        }
        public void getData()
        {
            List<model.xuathang> data = new List<model.xuathang>();
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();

            string Query = "Select*from Qlxuat";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {

                model.xuathang obj = new model.xuathang();
                obj.Maxuat = (string)rd["maxuat"];
                obj.Tennv= (string)rd["tennv"];
                obj.Mahang = (string)rd["mahang"];
                obj.Ngayxuat = (DateTime)rd["ngayxuat"];
                obj.Tenkh = (string)rd["tenkh"];
                obj.Soluongxuat = (int)rd["soluongxuat"];
                obj.Giaxuat = (double)rd["giaxuat"];
                obj.Thue = (double)rd["thue"];
                obj.Thanhtien = (double)rd["thanhtien"];
                data.Add(obj);
            }
            conn.Close();
            bang.DataSource = data;
            
        }
        bool kiemtranhap()
        {
            if (txtmapx.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập mã phiếu xuất";
                txtmapx.Focus();
                return false;
            }
            if (txtkh.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập tên khách hàng";
                txtkh.Focus();
                return false;
            }
            if (txtslx.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập số lượng xuất";
                txtslx.Focus();
                return false;
            }
            if (txtgiaxuat.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy điền giá xuất";
                txtgiaxuat.Focus();
                return false;
            }
            if (txtthue.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập số thuế";
                txtthue.Focus();
                return false;
            }
            return true;
        }
        bool kiemtraid()
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 maxuat FROM Qlxuat where maxuat='" + txtmapx.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Mã xuất đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            conn.Close();
            return true;
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
            int a = Convert.ToInt32(txtslkho.Text);
            int b = Convert.ToInt32(txtslx.Text);
            int sosanh = b - a;
            string mapx = txtmapx.Text;
            DateTime ngayxuat = this.date.Value;
            string tenkh = txtkh.Text;
            string tennv = this.cbnv.GetItemText(this.cbnv.SelectedItem);
            string mahang = this.cbmahang.GetItemText(this.cbmahang.SelectedItem);
            string soluongxuat = txtslx.Text;
            string giaxuat = txtgiaxuat.Text;
            string thue = txtthue.Text;


            if (sosanh <= 0)
            {

                string Query = $"Insert into Qlxuat(maxuat,mahang,tennv,ngayxuat,tenkh,soluongxuat,giaxuat,thue) Values ('" + mapx + "','" + mahang + "',N'" + tennv + "', '" + ngayxuat + "', N'" + tenkh + "',  '" + soluongxuat + "', '" + giaxuat + "','" + thue + "')";
                SqlCommand cmd = new SqlCommand(Query, conn);
                int s1 = cmd.ExecuteNonQuery();
                if (s1 > 0)
                {

                    lb.ForeColor = Color.Blue;
                    lb.Text = "Thêm thành công";
                    
                    List<model.xemay> data = new List<model.xemay>();
                    string con_tr1 = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
                    SqlConnection conn1 = new SqlConnection(con_tr1);
                    conn1.Open();

                    string Query1 = "Select*from Qlhanghoa";
                    SqlCommand cmd1 = new SqlCommand(Query1, conn1);
                    SqlDataReader rd1 = cmd1.ExecuteReader();
                    while (rd1.Read())
                    {

                        model.xemay obj = new model.xemay();
                       
                        obj.Mahang = (string)rd1["mahang"];
                        obj.Soluong = (int)rd1["soluong"];
                        data.Add(obj);
                    }
                    conn1.Close();
                    cbmahang.DataSource = data;
                    cbmahang.DisplayMember = "mahang";
                    cbmahang.ValueMember = "soluong";
                    txtslkho.DataBindings.Clear();
                    txtslkho.DataBindings.Add("Text", cbmahang.DataSource, "soluong");
                }
                else
                {
                    lb.ForeColor = Color.Red;
                    lb.Text = "Thêm thất bại";
                }
                conn.Close();
                getData();
              
               
            }
            else
            {
                MessageBox.Show("Mặt hàng này hiện tại không đủ hoặc đã hết", "Thông Báo");
            }
            
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            if (txtmapx.Text == "")
            {
                lb.Text = "Hãy nhập mã phiếu xuất ";
                lb.ForeColor = Color.Red;
                return;
            }
            string mapx = txtmapx.Text;
            DateTime ngayxuat = this.date.Value;
            string tenkh = txtkh.Text;
            string manv = this.cbnv.GetItemText(this.cbnv.SelectedItem);
            string mahang = this.cbmahang.GetItemText(this.cbmahang.SelectedItem);
            string soluongxuat = txtslx.Text;
            string giaxuat = txtgiaxuat.Text;
            string thue = txtthue.Text;

            string Query = $"Update Qlxuat set mahang='"+mahang+ "',tennv=N'" + manv + "',ngayxuat='" + ngayxuat + "' ,tenkh=N'" + tenkh + "' , soluongxuat='" + soluongxuat + "' ,   giaxuat='" + giaxuat + "', thue='" + thue + "' where  maxuat='"+mapx+"'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int s1 = cmd.ExecuteNonQuery();

            if (s1 > 0)
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
            if (txtmapx.Text == "")
            {
                lb.Text = "Hãy nhập mã phiếu xuất ";
                lb.ForeColor = Color.Red;
                return;
            }
            string mapx = txtmapx.Text;
            DateTime ngayxuat = this.date.Value;
            string tenkh = txtkh.Text;
            string manv = this.cbnv.GetItemText(this.cbnv.SelectedItem);
            string mahang = this.cbmahang.GetItemText(this.cbmahang.SelectedItem);
            string soluongxuat = txtslx.Text;
            string giaxuat = txtgiaxuat.Text;
            string thue = txtthue.Text;

            string Query = $"Delete from Qlxuat where maxuat='"+mapx+"'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int s1 = cmd.ExecuteNonQuery();

            if (s1 > 0)
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

        private void btnhuy_Click(object sender, EventArgs e)
        {
            getData();
            txtmapx.Text = "";
            txtkh.Text = "";
            txtslx.Text = "";
            txtgiaxuat.Text = "";
            txtthue.Text = "";
            txtmapx.Enabled = true;
            btnthem.Enabled = true;
            lb.Text = "";
        }

        private void bang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.bang.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtmapx.Text = row.Cells[0].Value.ToString();
                cbnv.Text = row.Cells[2].Value.ToString();
                cbmahang.Text = row.Cells[1].Value.ToString();
                txtkh.Text = row.Cells[4].Value.ToString();
                date.Text = row.Cells[3].Value.ToString();
                txtslx.Text = row.Cells[5].Value.ToString();
                txtgiaxuat.Text = row.Cells[6].Value.ToString();
                txtthue.Text = row.Cells[7].Value.ToString();
            }
            btnthem.Enabled = false;
            txtmapx.Enabled = false;
        }

        private void btnngaytk_Click(object sender, EventArgs e)
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "select * from Qlxuat where ngayxuat='" + datetk.Text + "'";
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
            string sql = "select * from Qlxuat where tennv='" + txttennvtk.Text + "'";
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

        private void cbtenhang_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtgiaxuat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
