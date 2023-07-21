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
    public partial class addStudent : Form
    {
        public addStudent()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Blue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // tên , id,điểm ,thành phố,quê quán
            char splier = ';';
            string[] check = { textBox1.Text.Trim(), textBox2.Text.Trim(), textBox4.Text.Trim(), textBox6.Text.Trim(), textBox5.Text.Trim() };

            if (check.All(s => s != string.Empty))
            {
                label6.ForeColor = Color.Green;
                string student = textBox1.Text.Trim() + splier + textBox2.Text.Trim() + splier + textBox4.Text.Trim() + splier + textBox6.Text.Trim() + splier + textBox5.Text.Trim();
                Account.AddStudent(student);
                MessageBox.Show("Đã thêm sinh viên thành công", "THÊM SINH VIÊN ", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                label6.ForeColor = Color.Red;
                label6.Text = "Không được bỏ trống";
            }
        }
    }
}
