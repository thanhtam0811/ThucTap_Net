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
using System.Media;

namespace Phần_mềm_quản_lý_cửa_hàng_xe_máy
{
    public partial class trangchu : Form
    {

        string taikhoan = "", matkhau = "", email = "", quyen = "";
        public trangchu()
        {
            this.Width = 1269;
            this.Height = 905;
            InitializeComponent();

        }

        public trangchu(string taikhoan, string matkhau, string email, string quyen)
        {
            InitializeComponent();
            this.taikhoan = taikhoan;
            this.matkhau = matkhau;
            this.email = email;
            this.quyen = quyen;
        }

      
        private void trangchu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            label1.Text = DateTime.Now.ToLongTimeString();
            
        }
       

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void pn_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        private Form currentFormChild;

        private void OpenChildForm(Form childForm)
        {
            if(currentFormChild!=null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pn.Controls.Add(childForm);
            pn.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
       

        private void lbdmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new doimatkhau());
            label1.ForeColor = Color.Blue;
            label1.Text = "Đổi Mật Khẩu";
            label1.BackColor = Color.White;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            
        }

        private void lbdx_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            dangnhap form2 = new dangnhap();
            form2.ShowDialog();
            this.Close();
        }

        private void lbthoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            this.Close();
        }

        private void linknv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (quyen == "admin")
            {
                OpenChildForm(new nhanvien());
                label1.ForeColor = Color.Blue;
                label1.Text = "Quản LýNhân Viên";
                label1.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!","Thông báo");
                
            }
           
        }

        private void lbxe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            
                OpenChildForm(new xemay());
                label1.ForeColor = Color.Blue;
                label1.Text = "Quản Lý Hàng hoá";
                label1.BackColor = Color.White;
           
        }

        private void lbluong_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (quyen == "admin")
            {
                OpenChildForm(new luong());
                label1.ForeColor = Color.Blue;
                label1.Text = "Quản Lý Lương";
                label1.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Thông báo");
            }
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbdate.Text = DateTime.Now.ToLongTimeString();
        }

        private void lbdate_Click(object sender, EventArgs e)
        {

        }

        private void lbncc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
                OpenChildForm(new nhacungcap());
                label1.ForeColor = Color.Blue;
                label1.Text = "Quản Lý Nhà Cung Cấp";
                label1.BackColor = Color.White;
            
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new Qlnhaphang());
            label1.ForeColor = Color.Blue;
            label1.Text = "Quản Lý Nhập Hàng";
            label1.BackColor = Color.White;
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OpenChildForm(new xuathang());
            label1.ForeColor = Color.Blue;
            label1.Text = "Quản Lý Xuất Hàng";
            label1.BackColor = Color.White;
        }

        private void pn_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            this.Hide();
            dangnhap form2 = new dangnhap();
            form2.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                OpenChildForm(new nhanvien());
                label1.ForeColor = Color.Blue;
                label1.Text = "Quản LýNhân Viên";
                label1.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Thông báo");
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                OpenChildForm(new xemay());
                label1.ForeColor = Color.Blue;
                label1.Text = "Quản Lý Hàng hoá";
                label1.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Thông báo");
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                OpenChildForm(new nhacungcap());
                label1.ForeColor = Color.Blue;
                label1.Text = "Quản Lý Nhà Cung Cấp";
                label1.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Thông báo");
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            if (quyen == "admin")
            {
                OpenChildForm(new luong());
                label1.ForeColor = Color.Blue;
                label1.Text = "Quản Lý Lương";
                label1.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Thông báo");
            }
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Qlnhaphang());
            label1.ForeColor = Color.Blue;
            label1.Text = "Quản Lý Nhập Hàng";
            label1.BackColor = Color.White;
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new xuathang());
            label1.ForeColor = Color.Blue;
            label1.Text = "Quản Lý Xuất Hàng";
            label1.BackColor = Color.White;
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenChildForm(new baocaonhap());
            label1.ForeColor = Color.Blue;
            label1.Text = "Báo Cáo Nhập Hàng";
            label1.BackColor = Color.White;
        }

        private void phiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Baocaoxuat());
            label1.ForeColor = Color.Blue;
            label1.Text = "Báo Cáo Xuất Hàng";
            label1.BackColor = Color.White;
        }

        private void troToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pic1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pn_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OpenChildForm(new baocaonhap());
            label1.ForeColor = Color.Blue;
            label1.Text = "Báo Cáo Nhập Hàng";
            label1.BackColor = Color.White;
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenChildForm(new Baocaoxuat());
            label1.ForeColor = Color.Blue;
            label1.Text = "Báo Cáo Nhập Hàng";
            label1.BackColor = Color.White;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new doimatkhau());
        }
    }
}
