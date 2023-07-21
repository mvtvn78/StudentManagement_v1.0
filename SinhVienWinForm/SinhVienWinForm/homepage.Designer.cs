namespace SinhVienWinForm
{
    partial class homepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepage));
            this.login = new System.Windows.Forms.Button();
            this.qlsvlabel = new System.Windows.Forms.Label();
            this.logup = new System.Windows.Forms.Button();
            this.fgpassw = new System.Windows.Forms.Button();
            this.ownerlabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.LightCoral;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.login.ForeColor = System.Drawing.Color.Snow;
            this.login.Location = new System.Drawing.Point(122, 133);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(591, 70);
            this.login.TabIndex = 2;
            this.login.Text = "Đăng nhập";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            this.login.MouseLeave += new System.EventHandler(this.login_MouseLeave);
            this.login.MouseMove += new System.Windows.Forms.MouseEventHandler(this.login_MouseMove);
            // 
            // qlsvlabel
            // 
            this.qlsvlabel.AutoSize = true;
            this.qlsvlabel.BackColor = System.Drawing.Color.Transparent;
            this.qlsvlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.qlsvlabel.ForeColor = System.Drawing.Color.Transparent;
            this.qlsvlabel.Location = new System.Drawing.Point(141, 40);
            this.qlsvlabel.Name = "qlsvlabel";
            this.qlsvlabel.Size = new System.Drawing.Size(542, 69);
            this.qlsvlabel.TabIndex = 3;
            this.qlsvlabel.Text = "Quản Lý Sinh Viên";
            // 
            // logup
            // 
            this.logup.BackColor = System.Drawing.Color.LightCoral;
            this.logup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.logup.ForeColor = System.Drawing.Color.Snow;
            this.logup.Location = new System.Drawing.Point(122, 230);
            this.logup.Name = "logup";
            this.logup.Size = new System.Drawing.Size(591, 70);
            this.logup.TabIndex = 4;
            this.logup.Text = "Đăng ký";
            this.logup.UseVisualStyleBackColor = false;
            this.logup.Click += new System.EventHandler(this.logup_Click);
            this.logup.MouseLeave += new System.EventHandler(this.logup_MouseLeave);
            this.logup.MouseMove += new System.Windows.Forms.MouseEventHandler(this.logup_MouseMove);
            // 
            // fgpassw
            // 
            this.fgpassw.BackColor = System.Drawing.Color.LightCoral;
            this.fgpassw.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.fgpassw.ForeColor = System.Drawing.Color.Snow;
            this.fgpassw.Location = new System.Drawing.Point(122, 335);
            this.fgpassw.Name = "fgpassw";
            this.fgpassw.Size = new System.Drawing.Size(591, 70);
            this.fgpassw.TabIndex = 5;
            this.fgpassw.Text = "Quên mật khẩu";
            this.fgpassw.UseVisualStyleBackColor = false;
            this.fgpassw.Click += new System.EventHandler(this.fgpassw_Click);
            this.fgpassw.MouseLeave += new System.EventHandler(this.fgpassw_MouseLeave);
            this.fgpassw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fgpassw_MouseMove);
            // 
            // ownerlabel1
            // 
            this.ownerlabel1.AutoSize = true;
            this.ownerlabel1.BackColor = System.Drawing.Color.Transparent;
            this.ownerlabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ownerlabel1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ownerlabel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ownerlabel1.Location = new System.Drawing.Point(722, 427);
            this.ownerlabel1.Name = "ownerlabel1";
            this.ownerlabel1.Size = new System.Drawing.Size(135, 17);
            this.ownerlabel1.TabIndex = 6;
            this.ownerlabel1.Text = "Được làm bởi Mvt ®";
            // 
            // homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SinhVienWinForm.Properties.Resources.Free_vector_000486_truu_tuong_ve_tay_mau_nuoc_bau_troi_va_nhung_dam_may_hinh_nen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.ownerlabel1);
            this.Controls.Add(this.fgpassw);
            this.Controls.Add(this.logup);
            this.Controls.Add(this.qlsvlabel);
            this.Controls.Add(this.login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(830, 500);
            this.Name = "homepage";
            this.Text = "Trang Chủ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.homepage_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label qlsvlabel;
        private System.Windows.Forms.Button logup;
        private System.Windows.Forms.Button fgpassw;
        private System.Windows.Forms.Label ownerlabel1;
    }
}