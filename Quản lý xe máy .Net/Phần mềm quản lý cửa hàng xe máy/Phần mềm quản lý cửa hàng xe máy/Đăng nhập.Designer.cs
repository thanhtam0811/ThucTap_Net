namespace Phần_mềm_quản_lý_cửa_hàng_xe_máy
{
    partial class dangnhap
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
            this.ldk = new System.Windows.Forms.LinkLabel();
            this.lqmk = new System.Windows.Forms.LinkLabel();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.butthoat = new System.Windows.Forms.Button();
            this.btndn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ldk
            // 
            this.ldk.AutoSize = true;
            this.ldk.BackColor = System.Drawing.Color.Transparent;
            this.ldk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ldk.Location = new System.Drawing.Point(352, 252);
            this.ldk.Name = "ldk";
            this.ldk.Size = new System.Drawing.Size(57, 16);
            this.ldk.TabIndex = 17;
            this.ldk.TabStop = true;
            this.ldk.Text = "Đăng ký";
            this.ldk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ldk_LinkClicked);
            // 
            // lqmk
            // 
            this.lqmk.AutoSize = true;
            this.lqmk.BackColor = System.Drawing.Color.Transparent;
            this.lqmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lqmk.Location = new System.Drawing.Point(87, 261);
            this.lqmk.Name = "lqmk";
            this.lqmk.Size = new System.Drawing.Size(97, 16);
            this.lqmk.TabIndex = 16;
            this.lqmk.TabStop = true;
            this.lqmk.Text = "Quên mật khẩu";
            this.lqmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lqmk_LinkClicked);
            // 
            // txtmk
            // 
            this.txtmk.AcceptsTab = true;
            this.txtmk.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.Location = new System.Drawing.Point(169, 175);
            this.txtmk.Name = "txtmk";
            this.txtmk.PasswordChar = '*';
            this.txtmk.Size = new System.Drawing.Size(241, 35);
            this.txtmk.TabIndex = 14;
            // 
            // txttk
            // 
            this.txttk.AcceptsTab = true;
            this.txttk.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txttk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttk.Location = new System.Drawing.Point(169, 119);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(241, 35);
            this.txttk.TabIndex = 13;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.Transparent;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(144, 81);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 25);
            this.lb.TabIndex = 20;
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(143, 38);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(222, 39);
            this.linkLabel1.TabIndex = 23;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Acount Login";
            // 
            // butthoat
            // 
            this.butthoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butthoat.Image = global::Phần_mềm_quản_lý_cửa_hàng_xe_máy.Properties.Resources.exit;
            this.butthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butthoat.Location = new System.Drawing.Point(306, 298);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(133, 44);
            this.butthoat.TabIndex = 21;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = false;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // btndn
            // 
            this.btndn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndn.Image = global::Phần_mềm_quản_lý_cửa_hàng_xe_máy.Properties.Resources.Login_icon_32;
            this.btndn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndn.Location = new System.Drawing.Point(51, 298);
            this.btndn.Name = "btndn";
            this.btndn.Size = new System.Drawing.Size(133, 44);
            this.btndn.TabIndex = 18;
            this.btndn.Text = "Đăng Nhập";
            this.btndn.UseVisualStyleBackColor = false;
            this.btndn.Click += new System.EventHandler(this.btndn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 29);
            this.label1.TabIndex = 54;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 55;
            this.label2.Text = "Mật Khẩu";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(169, 226);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(122, 19);
            this.checkBox1.TabIndex = 57;
            this.checkBox1.Text = "Hiển thị mật khẩu";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dangnhap
            // 
            this.AcceptButton = this.btndn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 352);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.butthoat);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btndn);
            this.Controls.Add(this.ldk);
            this.Controls.Add(this.lqmk);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txttk);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dangnhap";
            this.Text = "Đăng nhập";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndn;
        private System.Windows.Forms.LinkLabel ldk;
        private System.Windows.Forms.LinkLabel lqmk;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

