using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22651230.ClassModel
{
    public class Workers
    {
        private string firstName;
        private string lastName;
        private string phone;

        public Workers(string firstName, string lastName, string phone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
        }
        public Workers()
        {         
            this.firstName = "";
            this.lastName = "";
            this.phone = "";
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
