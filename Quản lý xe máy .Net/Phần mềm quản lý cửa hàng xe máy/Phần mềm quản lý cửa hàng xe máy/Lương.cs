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
    public partial class luong : Form
    {
        public luong()
        {
            InitializeComponent();
        }

        private void Lương_Load(object sender, EventArgs e)
        {
            txtlcb.Enabled = false;
            getData();
            getDataNV();
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
                obj.Chucvu = (string)rd["chucvu"];
                obj.Luongcoban = (double)rd["luongcoban"];
                data.Add(obj);
               
            }
            conn.Close();
            cbten.DataSource = data;
            cbten.DisplayMember = "manv";
            cbten.ValueMember = "chucvu";
            txtcv.DataBindings.Clear();
            txtcv.DataBindings.Add("Text", cbten.DataSource, "chucvu");
            cbten.ValueMember = "luongcoban";
            txtlcb.DataBindings.Clear();
            txtlcb.DataBindings.Add("Text", cbten.DataSource, "luongcoban");
           
        }
        public void getData()
        {
            List<model.luong> data = new List<model.luong>();
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();

            string Query = "Select * from Qlluong ";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {

                model.luong obj = new model.luong();
                obj.Maluong = (string)rd["maluong"];
                obj.Manv = (string)rd["manv"];
                obj.Hesoluong = (double)rd["hesoluong"];
                obj.Tienluong = (double)rd["tienluong"];
                
                data.Add(obj);

            }
            conn.Close();
            bang.DataSource = data;
           


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
                obj.Manv = (string)rd["manv"];
                data.Add(obj);
            }
            conn.Close();
            cbten.DataSource = data;
            cbten.DisplayMember = "manv";
            cbten.ValueMember = "manv";

        }

        bool kiemtranhap()
        {
            if (txtma.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập mã";
                txtma.Focus();
                return false;
            }

            
            if (cbhsl.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy chọn hệ số lương";
                cbhsl.Focus();
                return false;
            }
            
            return true;
        }
        bool kiemtraid()
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "SELECT top 1 maluong FROM Qlluong where maluong='" + txtma.Text + "'";
            SqlCommand cmd1 = new SqlCommand(sql, conn);
            SqlDataReader rd = cmd1.ExecuteReader();
            if (rd.Read())
            {
                MessageBox.Show("Mã lương đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            conn.Close();
            return true;
        }
        private void btcn_Click(object sender, EventArgs e)
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string ma = txtma.Text;
            string manv = this.cbten.GetItemText(this.cbten.SelectedItem);
            string hsl = this.cbhsl.GetItemText(this.cbhsl.SelectedItem);
           if(!kiemtranhap())
            {
                return;
            }
           if(!kiemtraid())
            {
                return;
            }

            string Query = $"Insert into Qlluong(maluong,manv,hesoluong) Values ('" + ma + "','" + manv + "', '" + hsl + "')";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int s1 = cmd.ExecuteNonQuery();
            if (s1 >0)
            {
                getData();
                lb.ForeColor = Color.Blue;
                lb.Text = "Cập nhật thành công";
               
            }
            else
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Cập nhật thất bại";
            }
            conn.Close();
            

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string ma = txtma.Text;
            string tennv = this.cbten.GetItemText(this.cbten.SelectedItem);
            string hsl = this.cbhsl.GetItemText(this.cbhsl.SelectedItem);
           

            string Query = $"Delete from Qlluong Where maluong=N'"+ma+"'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int s1 = cmd.ExecuteNonQuery();
            if (s1 > 0)
            {
                getData();
                lb.ForeColor = Color.Blue;
                lb.Text = "Xoá thành công";

            }
            else
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Xoá thất bại";
            }
            conn.Close();
        }

        private void txtma_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.bang.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtma.Text = row.Cells[0].Value.ToString();
                cbten.Text = row.Cells[1].Value.ToString();
                cbhsl.Text = row.Cells[2].Value.ToString();
                
                
            }
            
            
        }

        private void bang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void bang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
        }
    }
}
