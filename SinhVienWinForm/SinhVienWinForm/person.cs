using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVienWinForm
{
     internal abstract class person
    {
      private string name;
      private  Address address;
        public person()
        {
            Name = string.Empty;
            Address = new Address();           
        }
        ~person()
        {
            Name = string.Empty;
            Address = new Address();
        }
        public string Name { get => name; set => name = value; }
        internal Address Address { get => address; set => address = value; }

        public abstract void InPut(string _name,Address _address,int _id,double _mark);
        public abstract void OutPut(string _name, Address _address, int _id, double _mark);
    }
}
