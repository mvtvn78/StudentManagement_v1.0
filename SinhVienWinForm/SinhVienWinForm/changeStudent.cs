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
    public partial class changeStudent : Form
    {
        private Students Ls;
        private int index;
        private Student sv;
        public changeStudent(int _index = -1)
        {
            this.index = _index;
            Ls = new Students();
            sv = Ls.students[index];
            InitializeComponent();
        }

        private void changeStudent_FormClosed(object sender, FormClosedEventArgs e)
        {          
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // tên , id,điểm ,thành phố,quê quán
            char splier = ';';
            string[] temp={ sv.Name.Trim(),sv.Id.ToString() ,sv.Avgmark.ToString() , sv.Address.City.Trim(), sv.Address.Country.Trim() };
            
            string[] check = { textBox1.Text.Trim(), textBox2.Text.Trim(), textBox4.Text.Trim(), textBox6.Text.Trim(), textBox5.Text.Trim() };

            if (!check.SequenceEqual(temp))
            {
                label6.ForeColor = Color.Green;
                string student = textBox1.Text.Trim() + splier + textBox2.Text.Trim() + splier + textBox4.Text.Trim() + splier + textBox6.Text.Trim() + splier + textBox5.Text.Trim();
                MessageBox.Show("Đổi Thành Công","Sửa đổi thông tin " + temp[0],MessageBoxButtons.OK) ;
                Account.ChangeStudent(index, student);                
                this.Close();
            }
            else
            {
                label6.ForeColor = Color.Green;
                label6.Text = "Không có sự thay đổi";
            }
        }

        private void changeStudent_Load(object sender, EventArgs e)
        {
            textBox1.Text = sv.Name;
            textBox2.Text = sv.Id.ToString();
            textBox5.Text = sv.Address.Country;
            textBox4.Text= sv.Avgmark.ToString();
            textBox6.Text = sv.Address.City;
             
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
           button1.BackColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }
    }
}
