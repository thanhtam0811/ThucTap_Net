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
    public partial class baocaonhap : Form
    {
        public baocaonhap()
        {
            InitializeComponent();
        }

        

        private void baocaonhap_Load(object sender, EventArgs e)
        {
            //this.QlnhapTableAdapter.Fill
            //    (this.DataSet1.Qlnhap);
            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
           
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.QlnhapTableAdapter.Fill(this.DataSet1.Qlnhap, dateTimePicker1.Text); this.reportViewer1.RefreshReport();

        }
    }
}
    

