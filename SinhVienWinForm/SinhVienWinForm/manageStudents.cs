using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using IOFILE;
namespace SinhVienWinForm
{
    public partial class manageStudents : Form
    {
        private Students Managements = new Students();
        public static int secondCount  = 5;
        private static async Task StartTimer( Panel panel1,Panel panel2,Button button,Label text)
        {
            text.AutoSize = true;
            while (secondCount!=0)
            {               
                await Task.Delay(1000);
                secondCount--;
                text.Text= $"Vui Lòng Chờ khoảng {secondCount} s";
                button.Enabled = false;
                panel1.Enabled = false;
                panel2.Enabled = false;
                if (secondCount==0)
                {
                    button.Enabled = true;
                    text.Visible = false;                 
                    button.Text = "Nhấn Nút Này để Trở Lại Trang Đăng Nhập";                     
                }
            }
        }
        
        private string account;
        private string passwd;
        public manageStudents(string account="maivantien594dz@gmail.com",string passwd = "")
        {
            this.account=account;
            this.passwd=passwd; 
            InitializeComponent();
           
        }

        private void manageStudents_Load(object sender, EventArgs e)
        {
            string nickName = this.account;
            this.Text = "Quản Lý Sinh Viên " + nickName;
            if (nickName.Length>13)
            {
                nickName=nickName.Substring(0,13);
                int size = nickName.Length;
                for(int dcr = size - 1;dcr>= size - 3;dcr--)
                {
                    nickName = nickName.Replace(nickName[dcr], '.');
                }
            }
            textBox1.Text = nickName;
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelStudents_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newpasswd= textBox2.Text.Trim();
            
            if(newpasswd == string.Empty)
            {
                MessageChange.Text = "Mật khẩu không phù hợp";
            }
            else if(newpasswd != textBox3.Text.Trim())
            {
                MessageChange.Text = "Mật khẩu không trùng khớp";
            }
            else
            {
                
                MessageChange.Text = "Đã Đổi Thành Công";
                MessageChange.ForeColor = Color.Green;
                
               
                var timer = StartTimer(panel7, panelInfo,button2,MessageChange);
                if (secondCount <= 0)
                {
                    Account.ChangePasswd(account, newpasswd);
                    button9_Click(sender, e);
                }

            }    
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Hide();
            if (signIn.ShowDialog() == DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            addStudent addStudent = new addStudent();
            if(addStudent.ShowDialog() == DialogResult.Cancel)
            {
                LvStudents.Items.Clear();
                Managements = new Students();
            }
        }

        private void DisplayStudent_Click(object sender, EventArgs e)
        {
            
            
            LvStudents.Items.Clear();
            for (int i = 0; i < Managements.students.Count; i++)
            {
                ListViewItem lvstudent = new ListViewItem((i + 1).ToString());
                lvstudent.SubItems.Add(Managements.students[i].Name);
                lvstudent.SubItems.Add(Managements.students[i].Id.ToString());
                lvstudent.SubItems.Add(Managements.students[i].Avgmark.ToString());
                lvstudent.SubItems.Add(Managements.students[i].Address.City + " / " + Managements.students[i].Address.Country);
                LvStudents.Items.Add(lvstudent);
            }
               
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            ListViewItem lv = LvStudents.SelectedItems[0];
            if (lv!= null)
            {               
                int index = int.Parse(lv.SubItems[0].Text) - 1;
                LvStudents.Items.RemoveAt(index);
                if (Account.RemoveStudent(index) != -1)
                {
                    MessageBox.Show("Đã Xóa Thành Công", "Management", MessageBoxButtons.OK);
                    Managements.students.RemoveAt(index);
                    LvStudents.Items.Clear();
                    DisplayStudent.PerformClick();
                }
            }    
        }

        private void ChangeStudent_Click(object sender, EventArgs e)
        {
            ListViewItem lv = LvStudents.SelectedItems[0];
            int index = int.Parse(lv.SubItems[0].Text) - 1;
            changeStudent change = new changeStudent(index);
            if(change.ShowDialog()==DialogResult.Cancel)
            {                
                LvStudents.Items.Clear();
                Managements = new Students();
            }
        }

        private void LvStudents_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void LvStudents_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void LvStudents_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void LvStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeleteStudent.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Transparent;
            button1.BackColor = Color.Blue;
            LvFucPanel.Enabled = true;
            LvFucPanel.Visible = true;
            LvPanel.Enabled = true;
            LvPanel.Visible = true;
            panelChangeInfo.Enabled = false;
            panelChangeInfo.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Blue;
            button1.BackColor = Color.Transparent;
            panelChangeInfo.Enabled = true;
            panelChangeInfo.Visible = true;
            LvFucPanel.Enabled =false;
            LvFucPanel.Visible = false;
            LvPanel.Enabled = false;
            LvPanel.Visible = false;
        }
    }
}
