using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SinhVienWinForm
{
    internal class Student : person
    {
        private int id;
        private double avgmark;
        public Student()
        {
            this.id = 0;
            this.avgmark = 0;
        }
        public Student(string _name,int _id,double _avgmark,string city,string country)
        {
            this.Name = _name;
            this.Id = _id;
            this.avgmark= _avgmark;
            this.Address.City = city;
            this.Address.Country = country;
        }
        ~Student() 
        {
            this.id = 0;
            this.avgmark = 0;
        }
        public int Id { get => id; set => id = value; }
        public double Avgmark { get => avgmark; set => avgmark = value; }
        public override void InPut(string _name, Address _address, int _id, double _mark)
        {
           this.Name= _name;
           this.Address= _address;
           this.Id= _id;
           this.Avgmark= _mark;
        }
        public override void OutPut(string _name="", Address _address=null, int _id=0, double _mark=0)
        {

            MessageBox.Show(this.Name +this.Id, this.avgmark + this.Address.City + this.Address.Country);
            _name = this.Name;
            _address = this.Address ;
            _id = this.Id;  
            _mark= this.Avgmark;
        }
    }
}
