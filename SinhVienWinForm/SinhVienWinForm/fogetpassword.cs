using IOFILE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVienWinForm
{
    public partial class fogetpassword : Form
    {
        public fogetpassword()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonIP3_Click(object sender, EventArgs e)
        {
            string accounts = Account.GetAccount();
            List<string> listaccount = new List<string>(accounts.Split('\n'));
            listaccount = listaccount.ConvertAll(x => x.Trim());
            int checkTk = listaccount.IndexOf(accIP3.Text.Trim());
            if (!CHECKverified3.Checked)
            {
                MessageBox.Show($"Vui lòng xác minh", "Forget PassWord", MessageBoxButtons.OK);
            }
            else if(checkTk %2 ==0 && checkTk !=-1)
            {
                MessageBox.Show($"Mật khẩu của bạn là \n{listaccount[checkTk + 1]}", "Forget PassWord", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.Cancel;            
            }
            else
            {
                MessageBox.Show($"Tài khoản không có trong danh sách", "Forget PassWord", MessageBoxButtons.OK);
            }    
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void accIP3_TextChanged(object sender, EventArgs e)
        {
            if(accIP3.Text==string.Empty) { labelaccIp.Visible = true; }
            else { labelaccIp.Visible = false; }
        }

        private void buttonIP3_MouseLeave(object sender, EventArgs e)
        {
            buttonIP3.BackColor=Color.White;
        }

        private void buttonIP3_MouseMove(object sender, MouseEventArgs e)
        {
            buttonIP3.BackColor = Color.CadetBlue;
            buttonIP3.Cursor = Cursors.Hand;
        }

        private void fogetpassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
