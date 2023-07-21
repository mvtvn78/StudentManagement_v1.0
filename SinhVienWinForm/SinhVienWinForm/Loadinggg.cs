using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVienWinForm
{
    public partial class Loadinggg : Form
    {
        private string account;
        private string password;
        public Loadinggg(string _account="",string _passwd = "")
        {
            this.account = _account;
            this.password = _passwd;
            InitializeComponent();          
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        

        
        private int progressValue = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            Thread thr = new Thread(new ThreadStart(() =>

            {
                Random random = new Random();
                int rand = random.Next(5, 35);
                if (rand + progressValue >= progressBar1.Maximum)
                    rand = progressBar1.Maximum - progressValue;
                progressValue += rand;
                string temp = "Loading" + ' ' + progressValue + '%';

                // Cập nhật giá trị mới cho ProgressBar            
                label1.Text = temp;
                progressBar1.Value = progressValue;

            }

            ));
            thr.IsBackground = true;
            thr.Start();

            // Nếu giá trị đã đạt tới giá trị tối đa, dừng Timer
            if (progressValue >= progressBar1.Maximum)
            {
                timer1.Stop();
                manageStudents managements = new manageStudents(this.account, this.password);
                this.Hide();
                if (managements.ShowDialog() == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            
        }

        private void Loadinggg_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Hàm trả về khi form tắt 
            this.DialogResult = DialogResult.Cancel;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
