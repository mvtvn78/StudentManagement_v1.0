using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IOFILE;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SinhVienWinForm
{
    public partial class SignIn : Form
    {
        static int count = 0;
        public SignIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                MessageBox.Show("Vui lòng Xác Minh", "Sign In", MessageBoxButtons.OK);
            }
            else
            {
                string accounts = Account.GetAccount();
                List<string> listaccount = new List<string>(accounts.Split('\n'));
                listaccount = listaccount.ConvertAll(x => x.Trim());
                int checkTk = listaccount.IndexOf(accIP1.Text.Trim());
                int checkMk = checkTk + 1;
                string check = "Tài khoản hoặc mật khẩu không chính xác\nVui lòng nhập lại";
                if (listaccount[checkMk] != passIP1.Text.Trim() && checkTk !=-1 )
                    MessageBox.Show(check, "Sign In", MessageBoxButtons.OK);
                else
                {
                    Loadinggg loadinggg = new Loadinggg(listaccount[checkTk], listaccount[checkMk]);
                    this.Hide();
                    if (loadinggg.ShowDialog() == DialogResult.Cancel)
                    {
                        this.Close();
                    }

                }
            }
            
        }

        private void CHECKverified1_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.facebook.com/sieuphammaitien594");
        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Hàm trả về khi form đã đóng
            this.DialogResult = DialogResult.Cancel;
        }

        private void accIP1_TextChanged(object sender, EventArgs e)
        {
            if(accIP1.Text==string.Empty)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void passIP1_TextChanged(object sender, EventArgs e)
        {
            if (passIP1.Text == string.Empty)
            {
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
            }
        }

        private void accntlabel1_Click(object sender, EventArgs e)
        {
            accIP1.Select();
        }

        private void passwlabel1_Click(object sender, EventArgs e)
        {
            passIP1.Select();
        }

        private void ownerlabel1_Click(object sender, EventArgs e)
        {
            CHECKverified1_Click(CHECKverified1, e);
        }

        private void buttonIP1_MouseLeave(object sender, EventArgs e)
        {
            buttonIP1.BackColor = Color.White;
        }

        private void buttonIP1_MouseMove(object sender, MouseEventArgs e)
        {
            buttonIP1.BackColor = Color.Blue;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            homepage hmpage = new homepage();
            this.Hide();
            if(hmpage.ShowDialog()== DialogResult.Cancel) {
            this.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.FixedSingle;
            count++;
            if(count % 2==0) { 
            passIP1.UseSystemPasswordChar = true;
            }
            else { passIP1.UseSystemPasswordChar =false ;}
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.BorderStyle = BorderStyle.None;
        }
    }
}
