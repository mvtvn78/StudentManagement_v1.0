using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IOFILE;
namespace SinhVienWinForm
{
    internal class Students
    {
        public List<Student> students = new List<Student>();
        private List<string> IOstudents;
        public Students()
        {
            IOstudents = Account.GetStudents();
            foreach(var item in IOstudents) {
                List<string> temp = new List<string>(item.Split(';'));
                if(temp.Count > 0) {
                    Student student = new Student(temp[0], int.Parse(temp[1]), double.Parse(temp[2] = temp[2].Replace(".", ",")), temp[3].ToString(), temp[4].ToString());
                    students.Add(student);
                }
                
            }          
        }
        public void Input(string _name,Address _address,int _id,float _mark)
        { 
            Student student = new Student();
            student.InPut(_name, _address, _id, _mark);
            students.Add(student);    
        }
        public void Output()
        {
           
        }
        public void Change(int index)
        {
            //students[index].InPut();
        }
        public void Sort()
        {

        }
        public int Find(string _name)
        {
            for(int i=0;i<students.Count;i++)
            {
                if (students[i].Name == _name)
                    return i;
            }
            return -1;
        }
        public int isGreaterStudent()
        {
            return -1;
        }
        public int isWorstStudent()
        {
            return -1;
        }
    }
}
