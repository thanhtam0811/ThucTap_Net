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
using Microsoft.Reporting.WinForms;

namespace Phần_mềm_quản_lý_cửa_hàng_xe_máy
{
    public partial class Baocaoxuat : Form
    {
        public Baocaoxuat()
        {
            InitializeComponent();
        }

        private void Phiếu_xuất_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.Qlxuat' table. You can move, or remove it, as needed.
            //this.QlxuatTableAdapter.Fill(this.DataSet1.Qlxuat);
            //this.QlxuatTableAdapter.Fill(this.DataSet1.Qlxuat);
            //this.reportViewer2.RefreshReport();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.QlxuatTableAdapter.Fill(this.DataSet1.Qlxuat, dateTimePicker1.Text); this.reportViewer2.RefreshReport();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
