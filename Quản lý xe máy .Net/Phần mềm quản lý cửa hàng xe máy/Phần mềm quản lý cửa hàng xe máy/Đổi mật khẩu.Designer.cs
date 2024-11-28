namespace Phần_mềm_quản_lý_cửa_hàng_xe_máy
{
    partial class doimatkhau
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btndmk = new System.Windows.Forms.Button();
            this.txttk = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txtmkm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(518, 71);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(584, 72);
            this.linkLabel1.TabIndex = 47;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Change Account Password";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Image = global::Phần_mềm_quản_lý_cửa_hàng_xe_máy.Properties.Resources.exit;
            this.btnthoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthoat.Location = new System.Drawing.Point(810, 586);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(230, 68);
            this.btnthoat.TabIndex = 45;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btndmk
            // 
            this.btndmk.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndmk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndmk.Location = new System.Drawing.Point(357, 586);
            this.btndmk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndmk.Name = "btndmk";
            this.btndmk.Size = new System.Drawing.Size(226, 68);
            this.btndmk.TabIndex = 43;
            this.btndmk.Text = "Đổi mật khẩu";
            this.btndmk.UseVisualStyleBackColor = false;
            this.btndmk.Click += new System.EventHandler(this.btndmk_Click);
            // 
            // txttk
            // 
            this.txttk.AcceptsTab = true;
            this.txttk.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txttk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttk.ForeColor = System.Drawing.SystemColors.Info;
            this.txttk.Location = new System.Drawing.Point(522, 272);
            this.txttk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(492, 48);
            this.txttk.TabIndex = 38;
            this.txttk.Text = "Nhập tài khoản đăng nhập";
            this.txttk.TextChanged += new System.EventHandler(this.txttk_TextChanged);
            this.txttk.Enter += new System.EventHandler(this.txttk_Enter);
            this.txttk.Leave += new System.EventHandler(this.txttk_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Phần_mềm_quản_lý_cửa_hàng_xe_máy.Properties.Resources.banker_flat_icon_png_238399;
            this.pictureBox1.Location = new System.Drawing.Point(50, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 245);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.Color.Transparent;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.DarkRed;
            this.lb.Location = new System.Drawing.Point(447, 534);
            this.lb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 33);
            this.lb.TabIndex = 50;
            // 
            // txtmk
            // 
            this.txtmk.AcceptsTab = true;
            this.txtmk.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmk.ForeColor = System.Drawing.SystemColors.Info;
            this.txtmk.Location = new System.Drawing.Point(522, 346);
            this.txtmk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(492, 48);
            this.txtmk.TabIndex = 51;
            this.txtmk.Text = "Nhập mật khẩu cũ";
            this.txtmk.Enter += new System.EventHandler(this.txtmk_Enter_1);
            this.txtmk.Leave += new System.EventHandler(this.txtmk_Leave_1);
            // 
            // txtmkm
            // 
            this.txtmkm.AcceptsTab = true;
            this.txtmkm.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtmkm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmkm.ForeColor = System.Drawing.SystemColors.Info;
            this.txtmkm.Location = new System.Drawing.Point(522, 431);
            this.txtmkm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmkm.Name = "txtmkm";
            this.txtmkm.Size = new System.Drawing.Size(492, 48);
            this.txtmkm.TabIndex = 52;
            this.txtmkm.Text = "Nhập mật khẩu mới";
            this.txtmkm.Enter += new System.EventHandler(this.txtmkm_Enter_1);
            this.txtmkm.Leave += new System.EventHandler(this.txtmkm_Leave_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 282);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 40);
            this.label1.TabIndex = 53;
            this.label1.Text = "Tài Khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 355);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 40);
            this.label2.TabIndex = 54;
            this.label2.Text = "Mật Khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(242, 440);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 40);
            this.label3.TabIndex = 55;
            this.label3.Text = "Mật Khẩu Mới";
            // 
            // doimatkhau
            // 
            this.AcceptButton = this.btndmk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1255, 745);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtmkm);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndmk);
            this.Controls.Add(this.txttk);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "doimatkhau";
            this.Text = "Đổi_mật_khẩu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btndmk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txtmkm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
    }
}