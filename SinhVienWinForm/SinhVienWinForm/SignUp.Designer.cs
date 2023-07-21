namespace SinhVienWinForm
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.passIP2 = new System.Windows.Forms.TextBox();
            this.accIP2 = new System.Windows.Forms.TextBox();
            this.buttonIP2 = new System.Windows.Forms.Button();
            this.ownerlabel2 = new System.Windows.Forms.Label();
            this.passwlabel2 = new System.Windows.Forms.Label();
            this.accntlabel2 = new System.Windows.Forms.Label();
            this.CHECKpasswlabel1 = new System.Windows.Forms.Label();
            this.verifypassIP2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.Label();
            this.pr1 = new System.Windows.Forms.Label();
            this.pr2 = new System.Windows.Forms.Label();
            this.pr3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBox1.Location = new System.Drawing.Point(249, 282);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 29);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Xác Minh";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // passIP2
            // 
            this.passIP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.passIP2.Location = new System.Drawing.Point(249, 147);
            this.passIP2.Multiline = true;
            this.passIP2.Name = "passIP2";
            this.passIP2.PasswordChar = '*';
            this.passIP2.Size = new System.Drawing.Size(398, 37);
            this.passIP2.TabIndex = 16;
            this.passIP2.TextChanged += new System.EventHandler(this.passIP2_TextChanged);
            // 
            // accIP2
            // 
            this.accIP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.accIP2.Location = new System.Drawing.Point(249, 94);
            this.accIP2.Multiline = true;
            this.accIP2.Name = "accIP2";
            this.accIP2.Size = new System.Drawing.Size(398, 37);
            this.accIP2.TabIndex = 15;
            this.accIP2.TextChanged += new System.EventHandler(this.accIP2_TextChanged);
            // 
            // buttonIP2
            // 
            this.buttonIP2.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonIP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonIP2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonIP2.FlatAppearance.BorderSize = 100;
            this.buttonIP2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonIP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonIP2.Location = new System.Drawing.Point(249, 331);
            this.buttonIP2.Name = "buttonIP2";
            this.buttonIP2.Size = new System.Drawing.Size(398, 69);
            this.buttonIP2.TabIndex = 14;
            this.buttonIP2.Text = "Đăng ký";
            this.buttonIP2.UseVisualStyleBackColor = false;
            this.buttonIP2.Click += new System.EventHandler(this.buttonIP2_Click);
            this.buttonIP2.MouseLeave += new System.EventHandler(this.buttonIP2_MouseLeave);
            this.buttonIP2.MouseHover += new System.EventHandler(this.buttonIP2_MouseHover);
            this.buttonIP2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonIP2_MouseMove);
            // 
            // ownerlabel2
            // 
            this.ownerlabel2.AutoSize = true;
            this.ownerlabel2.BackColor = System.Drawing.Color.Transparent;
            this.ownerlabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ownerlabel2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ownerlabel2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ownerlabel2.Location = new System.Drawing.Point(32, 409);
            this.ownerlabel2.Name = "ownerlabel2";
            this.ownerlabel2.Size = new System.Drawing.Size(163, 20);
            this.ownerlabel2.TabIndex = 13;
            this.ownerlabel2.Text = "Được làm bởi Mvt ®";
            // 
            // passwlabel2
            // 
            this.passwlabel2.AutoSize = true;
            this.passwlabel2.BackColor = System.Drawing.Color.Transparent;
            this.passwlabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.passwlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.passwlabel2.Location = new System.Drawing.Point(31, 155);
            this.passwlabel2.Name = "passwlabel2";
            this.passwlabel2.Size = new System.Drawing.Size(173, 29);
            this.passwlabel2.TabIndex = 12;
            this.passwlabel2.Text = "Nhập Mật khẩu";
            this.passwlabel2.Click += new System.EventHandler(this.passwlabel2_Click);
            // 
            // accntlabel2
            // 
            this.accntlabel2.AutoSize = true;
            this.accntlabel2.BackColor = System.Drawing.Color.Transparent;
            this.accntlabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accntlabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.accntlabel2.Location = new System.Drawing.Point(31, 97);
            this.accntlabel2.Name = "accntlabel2";
            this.accntlabel2.Size = new System.Drawing.Size(183, 29);
            this.accntlabel2.TabIndex = 11;
            this.accntlabel2.Text = "Nhập Tài khoản";
            this.accntlabel2.Click += new System.EventHandler(this.accntlabel2_Click);
            // 
            // CHECKpasswlabel1
            // 
            this.CHECKpasswlabel1.AutoSize = true;
            this.CHECKpasswlabel1.BackColor = System.Drawing.Color.Transparent;
            this.CHECKpasswlabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CHECKpasswlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CHECKpasswlabel1.Location = new System.Drawing.Point(31, 220);
            this.CHECKpasswlabel1.Name = "CHECKpasswlabel1";
            this.CHECKpasswlabel1.Size = new System.Drawing.Size(204, 29);
            this.CHECKpasswlabel1.TabIndex = 19;
            this.CHECKpasswlabel1.Text = "Nhập lại mật khẩu";
            this.CHECKpasswlabel1.Click += new System.EventHandler(this.CHECKpasswlabel1_Click);
            // 
            // verifypassIP2
            // 
            this.verifypassIP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.verifypassIP2.Location = new System.Drawing.Point(249, 212);
            this.verifypassIP2.Multiline = true;
            this.verifypassIP2.Name = "verifypassIP2";
            this.verifypassIP2.PasswordChar = '*';
            this.verifypassIP2.Size = new System.Drawing.Size(398, 37);
            this.verifypassIP2.TabIndex = 20;
            this.verifypassIP2.TextChanged += new System.EventHandler(this.verifypassIP2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(372, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 40);
            this.label1.TabIndex = 21;
            this.label1.Text = "Chào bạn đã đến với phần đăng ký\r\nChúc bạn một ngày vui vẻ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.BackColor = System.Drawing.Color.Transparent;
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.info.ForeColor = System.Drawing.Color.White;
            this.info.Location = new System.Drawing.Point(273, 9);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(283, 69);
            this.info.TabIndex = 22;
            this.info.Text = "SIGN UP";
            // 
            // pr1
            // 
            this.pr1.AutoSize = true;
            this.pr1.BackColor = System.Drawing.Color.White;
            this.pr1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pr1.Enabled = false;
            this.pr1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pr1.Location = new System.Drawing.Point(255, 102);
            this.pr1.Name = "pr1";
            this.pr1.Size = new System.Drawing.Size(196, 22);
            this.pr1.TabIndex = 23;
            this.pr1.Text = "nhập tài khoản vào đây";
            // 
            // pr2
            // 
            this.pr2.AutoSize = true;
            this.pr2.BackColor = System.Drawing.Color.White;
            this.pr2.Cursor = System.Windows.Forms.Cursors.Default;
            this.pr2.Enabled = false;
            this.pr2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pr2.Location = new System.Drawing.Point(255, 155);
            this.pr2.Name = "pr2";
            this.pr2.Size = new System.Drawing.Size(196, 22);
            this.pr2.TabIndex = 24;
            this.pr2.Text = "nhập mật khẩu vào đây";
            // 
            // pr3
            // 
            this.pr3.AutoSize = true;
            this.pr3.BackColor = System.Drawing.Color.White;
            this.pr3.Cursor = System.Windows.Forms.Cursors.Default;
            this.pr3.Enabled = false;
            this.pr3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pr3.Location = new System.Drawing.Point(255, 220);
            this.pr3.Name = "pr3";
            this.pr3.Size = new System.Drawing.Size(219, 22);
            this.pr3.TabIndex = 25;
            this.pr3.Text = "nhập lại mật khẩu vào đây";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SinhVienWinForm.Properties.Resources.images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pr3);
            this.Controls.Add(this.pr2);
            this.Controls.Add(this.pr1);
            this.Controls.Add(this.info);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.verifypassIP2);
            this.Controls.Add(this.CHECKpasswlabel1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.passIP2);
            this.Controls.Add(this.accIP2);
            this.Controls.Add(this.buttonIP2);
            this.Controls.Add(this.ownerlabel2);
            this.Controls.Add(this.passwlabel2);
            this.Controls.Add(this.accntlabel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUp_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox passIP2;
        private System.Windows.Forms.TextBox accIP2;
        private System.Windows.Forms.Button buttonIP2;
        private System.Windows.Forms.Label ownerlabel2;
        private System.Windows.Forms.Label passwlabel2;
        private System.Windows.Forms.Label accntlabel2;
        private System.Windows.Forms.Label CHECKpasswlabel1;
        private System.Windows.Forms.TextBox verifypassIP2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.Label pr1;
        private System.Windows.Forms.Label pr2;
        private System.Windows.Forms.Label pr3;
    }
}