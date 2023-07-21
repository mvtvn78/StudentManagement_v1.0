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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn login = new SignIn();
            if (login.ShowDialog() == DialogResult.Cancel)
                this.Close();
            
        }

        private void logup_Click(object sender, EventArgs e)
        {
            SignUp logup = new SignUp();
            logup.Show();
            
        }

        private void login_MouseMove(object sender, MouseEventArgs e)
        {
            login.BackColor = Color.Aquamarine;
            login.Cursor = Cursors.Hand;
        }

        private void login_MouseLeave(object sender, EventArgs e)
        {
            login.BackColor = Color.LightCoral;
        }

        private void logup_MouseMove(object sender, MouseEventArgs e)
        {
            logup.BackColor = Color.Aquamarine;
            logup.Cursor = Cursors.Hand;
            
        }

        private void logup_MouseLeave(object sender, EventArgs e)
        {
            logup.BackColor = Color.LightCoral;
        }

        private void fgpassw_MouseMove(object sender, MouseEventArgs e)
        {
            fgpassw.BackColor = Color.Aquamarine;
            fgpassw.Cursor = Cursors.Hand;
        }

        private void fgpassw_MouseLeave(object sender, EventArgs e)
        {
            fgpassw.BackColor = Color.LightCoral;
        }

        private void fgpassw_Click(object sender, EventArgs e)
        {
            fogetpassword fgpasswd = new fogetpassword();
            this.Hide();
            if(fgpasswd.ShowDialog()== DialogResult.Cancel)
            {
                this.Show(); 
            }
        }

        private void homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
