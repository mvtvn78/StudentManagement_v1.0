namespace SinhVienWinForm
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            this.accntlabel1 = new System.Windows.Forms.Label();
            this.passwlabel1 = new System.Windows.Forms.Label();
            this.ownerlabel1 = new System.Windows.Forms.Label();
            this.buttonIP1 = new System.Windows.Forms.Button();
            this.accIP1 = new System.Windows.Forms.TextBox();
            this.passIP1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CHECKverified1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHECKverified1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // accntlabel1
            // 
            this.accntlabel1.AutoSize = true;
            this.accntlabel1.BackColor = System.Drawing.Color.Transparent;
            this.accntlabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accntlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.accntlabel1.Location = new System.Drawing.Point(83, 142);
            this.accntlabel1.Name = "accntlabel1";
            this.accntlabel1.Size = new System.Drawing.Size(119, 29);
            this.accntlabel1.TabIndex = 1;
            this.accntlabel1.Text = "Tài khoản";
            this.accntlabel1.Click += new System.EventHandler(this.accntlabel1_Click);
            // 
            // passwlabel1
            // 
            this.passwlabel1.AutoSize = true;
            this.passwlabel1.BackColor = System.Drawing.Color.Transparent;
            this.passwlabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.passwlabel1.Location = new System.Drawing.Point(83, 196);
            this.passwlabel1.Name = "passwlabel1";
            this.passwlabel1.Size = new System.Drawing.Size(109, 29);
            this.passwlabel1.TabIndex = 2;
            this.passwlabel1.Text = "Mật khẩu";
            this.passwlabel1.Click += new System.EventHandler(this.passwlabel1_Click);
            // 
            // ownerlabel1
            // 
            this.ownerlabel1.AutoSize = true;
            this.ownerlabel1.BackColor = System.Drawing.Color.Transparent;
            this.ownerlabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ownerlabel1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ownerlabel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ownerlabel1.Location = new System.Drawing.Point(0, 353);
            this.ownerlabel1.Name = "ownerlabel1";
            this.ownerlabel1.Size = new System.Drawing.Size(163, 20);
            this.ownerlabel1.TabIndex = 3;
            this.ownerlabel1.Text = "Được làm bởi Mvt ®";
            this.ownerlabel1.Click += new System.EventHandler(this.ownerlabel1_Click);
            // 
            // buttonIP1
            // 
            this.buttonIP1.BackColor = System.Drawing.Color.White;
            this.buttonIP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonIP1.Location = new System.Drawing.Point(258, 284);
            this.buttonIP1.Name = "buttonIP1";
            this.buttonIP1.Size = new System.Drawing.Size(348, 66);
            this.buttonIP1.TabIndex = 4;
            this.buttonIP1.Text = "Đăng nhập";
            this.buttonIP1.UseVisualStyleBackColor = false;
            this.buttonIP1.Click += new System.EventHandler(this.button1_Click);
            this.buttonIP1.MouseLeave += new System.EventHandler(this.buttonIP1_MouseLeave);
            this.buttonIP1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonIP1_MouseMove);
            // 
            // accIP1
            // 
            this.accIP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.accIP1.Location = new System.Drawing.Point(208, 134);
            this.accIP1.Multiline = true;
            this.accIP1.Name = "accIP1";
            this.accIP1.Size = new System.Drawing.Size(398, 37);
            this.accIP1.TabIndex = 6;
            this.accIP1.TextChanged += new System.EventHandler(this.accIP1_TextChanged);
            // 
            // passIP1
            // 
            this.passIP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.passIP1.Location = new System.Drawing.Point(208, 193);
            this.passIP1.Multiline = true;
            this.passIP1.Name = "passIP1";
            this.passIP1.PasswordChar = '*';
            this.passIP1.Size = new System.Drawing.Size(398, 37);
            this.passIP1.TabIndex = 7;
            this.passIP1.TextChanged += new System.EventHandler(this.passIP1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBox1.Location = new System.Drawing.Point(276, 249);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 29);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Xác Minh";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SinhVienWinForm.Properties.Resources.ảnh;
            this.pictureBox1.Location = new System.Drawing.Point(293, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CHECKverified1
            // 
            this.CHECKverified1.BackColor = System.Drawing.Color.Transparent;
            this.CHECKverified1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CHECKverified1.Image = global::SinhVienWinForm.Properties.Resources.facebook_removebg_preview;
            this.CHECKverified1.Location = new System.Drawing.Point(414, 236);
            this.CHECKverified1.Name = "CHECKverified1";
            this.CHECKverified1.Size = new System.Drawing.Size(47, 42);
            this.CHECKverified1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CHECKverified1.TabIndex = 9;
            this.CHECKverified1.TabStop = false;
            this.CHECKverified1.Click += new System.EventHandler(this.CHECKverified1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(221, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "nhập tài khoản của bạn vào đây";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(219, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "nhập mật khẩu của bạn vào đây";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::SinhVienWinForm.Properties.Resources.homeimg;
            this.pictureBox2.Location = new System.Drawing.Point(169, 284);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(83, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::SinhVienWinForm.Properties.Resources.shwpaswd___Sao_chép;
            this.pictureBox3.Location = new System.Drawing.Point(562, 193);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // SignIn
            // 
            this.BackgroundImage = global::SinhVienWinForm.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 373);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CHECKverified1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.passIP1);
            this.Controls.Add(this.accIP1);
            this.Controls.Add(this.buttonIP1);
            this.Controls.Add(this.ownerlabel1);
            this.Controls.Add(this.passwlabel1);
            this.Controls.Add(this.accntlabel1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(764, 420);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(764, 420);
            this.Name = "SignIn";
            this.Text = "Sign In";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignIn_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CHECKverified1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label accntlabel1;
        private System.Windows.Forms.Label passwlabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ownerlabel1;
        private System.Windows.Forms.Button buttonIP1;
        private System.Windows.Forms.TextBox accIP1;
        private System.Windows.Forms.TextBox passIP1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox CHECKverified1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

