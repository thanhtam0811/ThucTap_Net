namespace Phần_mềm_quản_lý_cửa_hàng_xe_máy
{
    partial class luong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnxoa = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.cbten = new System.Windows.Forms.ComboBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btcn = new System.Windows.Forms.Button();
            this.txtlcb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbhsl = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcv = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bang)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bang
            // 
            this.bang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bang.Location = new System.Drawing.Point(-1, 238);
            this.bang.Name = "bang";
            this.bang.Size = new System.Drawing.Size(834, 244);
            this.bang.TabIndex = 0;
            this.bang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_CellClick);
            this.bang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bang_CellContentClick);
            this.bang.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.bang_RowsAdded);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnxoa);
            this.panel1.Controls.Add(this.lb);
            this.panel1.Controls.Add(this.cbten);
            this.panel1.Controls.Add(this.txtma);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btcn);
            this.panel1.Controls.Add(this.txtlcb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbhsl);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtcv);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 231);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Image = global::Phần_mềm_quản_lý_cửa_hàng_xe_máy.Properties.Resources.Actions_edit_delete_icon_16;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxoa.Location = new System.Drawing.Point(408, 185);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(119, 32);
            this.btnxoa.TabIndex = 15;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.Transparent;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(605, 197);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 20);
            this.lb.TabIndex = 14;
            // 
            // cbten
            // 
            this.cbten.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbten.FormattingEnabled = true;
            this.cbten.Location = new System.Drawing.Point(169, 130);
            this.cbten.Name = "cbten";
            this.cbten.Size = new System.Drawing.Size(129, 28);
            this.cbten.TabIndex = 13;
            // 
            // txtma
            // 
            this.txtma.AcceptsTab = true;
            this.txtma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtma.Location = new System.Drawing.Point(168, 78);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(130, 26);
            this.txtma.TabIndex = 12;
            this.txtma.TextChanged += new System.EventHandler(this.txtma_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã";
            // 
            // btcn
            // 
            this.btcn.BackColor = System.Drawing.Color.Transparent;
            this.btcn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcn.Image = global::Phần_mềm_quản_lý_cửa_hàng_xe_máy.Properties.Resources.Save_icon;
            this.btcn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcn.Location = new System.Drawing.Point(283, 183);
            this.btcn.Name = "btcn";
            this.btcn.Size = new System.Drawing.Size(119, 34);
            this.btcn.TabIndex = 10;
            this.btcn.Text = "Cập nhật";
            this.btcn.UseVisualStyleBackColor = false;
            this.btcn.Click += new System.EventHandler(this.btcn_Click);
            // 
            // txtlcb
            // 
            this.txtlcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlcb.Location = new System.Drawing.Point(590, 145);
            this.txtlcb.Name = "txtlcb";
            this.txtlcb.Size = new System.Drawing.Size(121, 26);
            this.txtlcb.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(437, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Lương cơ bản";
            // 
            // cbhsl
            // 
            this.cbhsl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbhsl.FormattingEnabled = true;
            this.cbhsl.Items.AddRange(new object[] {
            "1.5",
            "1.7",
            "1.9",
            "2.1",
            "2.3"});
            this.cbhsl.Location = new System.Drawing.Point(590, 88);
            this.cbhsl.Name = "cbhsl";
            this.cbhsl.Size = new System.Drawing.Size(121, 28);
            this.cbhsl.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hệ số lương";
            // 
            // txtcv
            // 
            this.txtcv.AutoSize = true;
            this.txtcv.BackColor = System.Drawing.Color.Transparent;
            this.txtcv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcv.Location = new System.Drawing.Point(165, 185);
            this.txtcv.Name = "txtcv";
            this.txtcv.Size = new System.Drawing.Size(105, 20);
            this.txtcv.TabIndex = 4;
            this.txtcv.Text = "........................";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chức vụ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bảng Lương Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên :";
            // 
            // luong
            // 
            this.AcceptButton = this.btcn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "luong";
            this.Text = "Lương";
            this.Load += new System.EventHandler(this.Lương_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btcn;
        private System.Windows.Forms.TextBox txtlcb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtcv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbten;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.ComboBox cbhsl;
        private System.Windows.Forms.Button btnxoa;
    }
}