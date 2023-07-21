using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinhVienWinForm
{
    internal class Address
    {
        public Address() {
            this.city = "";
            this.country = "";
        }
        ~Address()
        {
            this.city = "";
            this.country = "";
        }
        private string city;
        private string country;

        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }       
    }
}
