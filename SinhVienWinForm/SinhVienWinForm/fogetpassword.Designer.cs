namespace SinhVienWinForm
{
    partial class fogetpassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fogetpassword));
            this.accntlabel3 = new System.Windows.Forms.Label();
            this.accIP3 = new System.Windows.Forms.TextBox();
            this.CHECKverified3 = new System.Windows.Forms.CheckBox();
            this.buttonIP3 = new System.Windows.Forms.Button();
            this.labelaccIp = new System.Windows.Forms.Label();
            this.ownerlabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // accntlabel3
            // 
            this.accntlabel3.AutoSize = true;
            this.accntlabel3.BackColor = System.Drawing.Color.Transparent;
            this.accntlabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.accntlabel3.ForeColor = System.Drawing.Color.White;
            this.accntlabel3.Location = new System.Drawing.Point(104, 298);
            this.accntlabel3.Name = "accntlabel3";
            this.accntlabel3.Size = new System.Drawing.Size(133, 29);
            this.accntlabel3.TabIndex = 0;
            this.accntlabel3.Text = "Thông Tin";
            // 
            // accIP3
            // 
            this.accIP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.accIP3.Location = new System.Drawing.Point(257, 298);
            this.accIP3.Multiline = true;
            this.accIP3.Name = "accIP3";
            this.accIP3.Size = new System.Drawing.Size(293, 35);
            this.accIP3.TabIndex = 1;
            this.accIP3.TextChanged += new System.EventHandler(this.accIP3_TextChanged);
            // 
            // CHECKverified3
            // 
            this.CHECKverified3.AutoSize = true;
            this.CHECKverified3.BackColor = System.Drawing.Color.Transparent;
            this.CHECKverified3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CHECKverified3.ForeColor = System.Drawing.Color.White;
            this.CHECKverified3.Location = new System.Drawing.Point(332, 340);
            this.CHECKverified3.Name = "CHECKverified3";
            this.CHECKverified3.Size = new System.Drawing.Size(114, 26);
            this.CHECKverified3.TabIndex = 2;
            this.CHECKverified3.Text = "Xác Minh";
            this.CHECKverified3.UseVisualStyleBackColor = false;
            // 
            // buttonIP3
            // 
            this.buttonIP3.BackColor = System.Drawing.Color.White;
            this.buttonIP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.buttonIP3.Location = new System.Drawing.Point(275, 385);
            this.buttonIP3.Name = "buttonIP3";
            this.buttonIP3.Size = new System.Drawing.Size(245, 43);
            this.buttonIP3.TabIndex = 3;
            this.buttonIP3.Text = "Yêu Cầu Password";
            this.buttonIP3.UseVisualStyleBackColor = false;
            this.buttonIP3.Click += new System.EventHandler(this.buttonIP3_Click);
            this.buttonIP3.MouseLeave += new System.EventHandler(this.buttonIP3_MouseLeave);
            this.buttonIP3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonIP3_MouseMove);
            // 
            // labelaccIp
            // 
            this.labelaccIp.AutoSize = true;
            this.labelaccIp.BackColor = System.Drawing.Color.White;
            this.labelaccIp.Enabled = false;
            this.labelaccIp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelaccIp.Location = new System.Drawing.Point(271, 305);
            this.labelaccIp.Name = "labelaccIp";
            this.labelaccIp.Size = new System.Drawing.Size(196, 22);
            this.labelaccIp.TabIndex = 4;
            this.labelaccIp.Text = "nhập tài khoản vào đây";
            // 
            // ownerlabel1
            // 
            this.ownerlabel1.AutoSize = true;
            this.ownerlabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ownerlabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ownerlabel1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ownerlabel1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ownerlabel1.Location = new System.Drawing.Point(625, 421);
            this.ownerlabel1.Name = "ownerlabel1";
            this.ownerlabel1.Size = new System.Drawing.Size(163, 20);
            this.ownerlabel1.TabIndex = 5;
            this.ownerlabel1.Text = "Được làm bởi Mvt ®";
            // 
            // fogetpassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SinhVienWinForm.Properties.Resources.matma;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ownerlabel1);
            this.Controls.Add(this.labelaccIp);
            this.Controls.Add(this.buttonIP3);
            this.Controls.Add(this.CHECKverified3);
            this.Controls.Add(this.accIP3);
            this.Controls.Add(this.accntlabel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "fogetpassword";
            this.Text = "Required";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fogetpassword_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accntlabel3;
        private System.Windows.Forms.TextBox accIP3;
        private System.Windows.Forms.CheckBox CHECKverified3;
        private System.Windows.Forms.Button buttonIP3;
        private System.Windows.Forms.Label labelaccIp;
        private System.Windows.Forms.Label ownerlabel1;
    }
}