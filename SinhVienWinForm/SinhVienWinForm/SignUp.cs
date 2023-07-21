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
namespace SinhVienWinForm
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonIP2_Click(object sender, EventArgs e)

        {
            char endline = '\n';
            string accounts = Account.GetAccount();
            List<string> listaccount = new List<string>(accounts.Split(endline));
            listaccount = listaccount.ConvertAll(x => x.Trim());
            int checkTk = listaccount.IndexOf(accIP2.Text.Trim());
            string check = string.Empty;
            if (checkTk % 2 == 0 && checkTk != -1)
                MessageBox.Show("Tài khoản đã có\nVui Lòng Nhập Lại","SignUp",MessageBoxButtons.OK);
            else
            {
                if (!checkBox1.Checked)
                {
                    MessageBox.Show("Bạn chưa xác minh");                  
                }
                else if (passIP2.Text.Trim()== verifypassIP2.Text.Trim())
                {
                    string account = endline + accIP2.Text.Trim() + endline + passIP2.Text.Trim();
                    Account.SetAccount(account);
                    MessageBox.Show("Đã Đăng Ký Thành Công", "SignUp",MessageBoxButtons.OK);
                    // Trả lại khi đánh công thành công
                    this.DialogResult = DialogResult.Cancel;
                }
                else
                {
                    MessageBox.Show("Mật khẩu không trùng khớp\nVui Lòng Nhập Lại", "SignUp", MessageBoxButtons.OK);
                }    
            }
           
        }

        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            //trả về khi đóng
            this.DialogResult = DialogResult.Cancel;
        }

        private void accIP2_TextChanged(object sender, EventArgs e)
        {
            if(accIP2.Text==string.Empty) 
            {
                pr1.Visible = true;
            }
            else { 
                pr1.Visible = false; 
            }
        }

        private void passIP2_TextChanged(object sender, EventArgs e)
        {
            if(passIP2.Text==string.Empty) { pr2.Visible = true; }
            else { pr2.Visible = false; }
        }

        private void verifypassIP2_TextChanged(object sender, EventArgs e)
        {
            if(verifypassIP2.Text==string.Empty) { pr3.Visible = true; }
            else
            {
                 pr3.Visible = false;
            }
        }

        private void buttonIP2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void buttonIP2_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Blue;
        }

        private void buttonIP2_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.White;
        }

        private void accntlabel2_Click(object sender, EventArgs e)
        {
            accIP2.Select();
        }

        private void passwlabel2_Click(object sender, EventArgs e)
        {
            passIP2.Select();
        }

        private void CHECKpasswlabel1_Click(object sender, EventArgs e)
        {
            verifypassIP2.Select();
        }
    }
}
