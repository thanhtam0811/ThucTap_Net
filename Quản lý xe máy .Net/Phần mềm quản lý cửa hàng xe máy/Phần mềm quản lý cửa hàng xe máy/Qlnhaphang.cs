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
    public partial class Qlnhaphang : Form
    {

        string taikhoan = "", matkhau = "", email = "", quyen = "";
        public Qlnhaphang()
        {
            InitializeComponent();
        }

        public Qlnhaphang(string taikhoan, string matkhau, string email, string quyen)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.email = email;
            this.quyen = quyen;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void Qlnhaphang_Load(object sender, EventArgs e)
        {
           
            getData();
            getDataHH();
            getDataNCC();
            getDataNV();
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
            cbnv.DataSource = data;
            cbnv.DisplayMember = "manv";
            cbnv.ValueMember = "manv";

        }
        public void getDataNCC()
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
                data.Add(obj);
            }
            conn.Close();
            cbncc.DataSource = data;
            cbncc.DisplayMember = "macc";
            cbncc.ValueMember = "mancc";
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
            cbtenhang.DataSource = data;
            cbtenhang.DisplayMember = "mahang";
            cbtenhang.ValueMember = "mahang";
        }
        public void getData()
        {
            List<model.nhaphang> data = new List<model.nhaphang>();
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();

            string Query = "Select*from Qlnhap";
            SqlCommand cmd = new SqlCommand(Query, conn);
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {

                model.nhaphang obj = new model.nhaphang();
                obj.Manhap = (string)rd["manhap"];
                obj.Ngaynhap = (DateTime)rd["ngaynhap"];
                obj.Manv = (string)rd["manv"];
                obj.Mancc = (string)rd["mancc"];
                obj.Mahang = (string)rd["mahang"];
                obj.Soluongnhap = (int)rd["soluongnhap"];
                obj.Gianhap = (double)rd["gianhap"];
                obj.Thue = (double)rd["thue"];
                obj.Thanhtien = (double)rd["thanhtien"];
                data.Add(obj);
               
            }
            conn.Close();
            bang.DataSource = data;
            
           
        }
        bool kiemtranhap()
        {
            if (txtmapn.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập mã phiếu nhập";
                txtmapn.Focus();
                return false;
            }

            if (cbnv.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy chọn mã nhân viên";
                cbnv.Focus();
                return false;
            }
            if (cbncc.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy chọn mã nhà cung cấp";
                cbncc.Focus();
                return false;
            }
            if (cbtenhang.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy chọn mã hàng nhập";
                cbtenhang.Focus();
                return false;
            }
            if (txtsln.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy nhập số lượng nhập";
                txtsln.Focus();
                return false;
            }
            if (txtgianhap.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Hãy điền giá nhập";
                txtgianhap.Focus();
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
            string sql = "SELECT top 1 manhap FROM Qlnhap where manhap='" + txtmapn.Text + "'";
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
        
        private void btnthem_Click(object sender, EventArgs e)
        {

            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            
            if (!kiemtranhap())
            {
                return;
            }
            if (!kiemtraid())
            {
                return;
            }
            string mapn = txtmapn.Text;
            DateTime ngaynhap = this.date.Value;
            string tennv = this.cbnv.GetItemText(this.cbnv.SelectedItem);
            string ncc = this.cbncc.GetItemText(this.cbncc.SelectedItem);
            string tenhang = this.cbtenhang.GetItemText(this.cbtenhang.SelectedItem);
            string soluongnhap = txtsln.Text;
            string gianhap = txtgianhap.Text;
            string thue = txtthue.Text;

            string Query = $"Insert into Qlnhap(manhap,manv,mahang,mancc,ngaynhap,soluongnhap,gianhap,thue) Values ('" + mapn + "', '" + tennv + "', '" + tenhang + "','" + ncc + "', '" + ngaynhap + "', '" + soluongnhap + "', '" + gianhap + "','" + thue + "')";
            SqlCommand cmd = new SqlCommand(Query, conn);
            conn.Open();
            int s1 = cmd.ExecuteNonQuery();
            if (s1 > 0)
            {

                lb.ForeColor = Color.Blue;
                lb.Text = "Thêm thành công";
               
            }
            else
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Thêm thất bại";
            }
            conn.Close();
            getData();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            if (txtmapn.Text == "")
            {
                lb.Text = "Hãy nhập mã phiếu nhập ";
                lb.ForeColor = Color.Red;
                return;
            }
            string mapn = txtmapn.Text;
            DateTime ngaynhap = this.date.Value;
            string nhacungcap = cbncc.Text;
            string tennv = this.cbnv.GetItemText(this.cbnv.SelectedItem);
            string ncc = this.cbncc.GetItemText(this.cbncc.SelectedItem);
            string tenhang = this.cbtenhang.GetItemText(this.cbtenhang.SelectedItem);
            string soluongnhap = txtsln.Text;
            string gianhap = txtgianhap.Text;
            string thue = txtthue.Text;

            string Query = $"Update Qlnhap set manv='" + tennv + "' , mahang='" + tenhang + "' ,mancc ='" + nhacungcap + "' ,ngaynhap='"+ngaynhap+"', soluongnhap='" + soluongnhap + "' ,   gianhap='" + gianhap + "', thue='" + thue + "'  where manhap='" + mapn + "'";
            SqlCommand cmd = new SqlCommand(Query, conn);
            int s1 = cmd.ExecuteNonQuery();

            if (s1 >0)
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
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
           
            
                string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
                SqlConnection conn = new SqlConnection(con_tr);
                conn.Open();
                if (txtmapn.Text == "")
                {
                    lb.Text = "Hãy nhập mã phiếu nhập";
                    lb.ForeColor = Color.Red;
                    return;
                }
                string mapn = txtmapn.Text;
                DateTime ngaynhap = this.date.Value;
                string nhacungcap = cbncc.Text;
                string tennv = this.cbnv.GetItemText(this.cbnv.SelectedItem);
                string ncc = this.cbncc.GetItemText(this.cbncc.SelectedItem);
                string tenhang = this.cbtenhang.GetItemText(this.cbtenhang.SelectedItem);
                string soluongnhap = txtsln.Text;
                string gianhap = txtgianhap.Text;
                string thue = txtthue.Text;

                string Query = $"Delete from Qlnhap where manhap='" + mapn + "'";
                SqlCommand cmd = new SqlCommand(Query, conn);
                int s1 = cmd.ExecuteNonQuery();

                if (s1 >0)
                {

                    lb.ForeColor = Color.Blue;
                    lb.Text = "Xoá thành công";
                    getData();
                }
                else
                {
                    lb.ForeColor = Color.Red;
                    lb.Text = "Vui lòng kiểm tra lại ngày nhập hàng";
                }
            
          
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            getData();
            txtmapn.Text = "";

            txtsln.Text = "";
            txtgianhap.Text = "";
            txtthue.Text = "";
            txtmapn.Enabled = true;
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
                txtmapn.Text = row.Cells[0].Value.ToString();
                cbnv.Text = row.Cells[1].Value.ToString();
                cbtenhang.Text = row.Cells[2].Value.ToString();
                cbncc.Text = row.Cells[3].Value.ToString();
                
                date.Text = row.Cells[4].Value.ToString();
               
                txtsln.Text = row.Cells[5].Value.ToString();
                txtgianhap.Text = row.Cells[6].Value.ToString();
                txtthue.Text = row.Cells[7].Value.ToString();
            }
            btnthem.Enabled = false;
            txtmapn.Enabled = false;

        }

        private void btnngaytk_Click(object sender, EventArgs e)
        {
            
            string con_tr = @"Data Source=DATNGUYEN\SQLEXPRESS; INitial Catalog=QuanLyXeMay; Integrated Security=SSPI;";
            SqlConnection conn = new SqlConnection(con_tr);
            conn.Open();
            string sql = "select * from Qlnhap where ngaynhap='" + datetk.Text + "'";
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
            string sql = "select * from Qlnhap where manv='" + txttennvtk.Text + "'";
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

        private void bang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbnv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
