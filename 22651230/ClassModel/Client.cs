using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22651230.ClassModel
{
    public class Client
    {
        private string firstName;
        private string lastName;    
        private string adres;
        private string phone;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Adres { get => adres; set => adres = value; }
        public string Phone { get => phone; set => phone = value; }

        public Client(string firstName, string lastName, string adres, string phone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.adres = adres;
            this.phone = phone;
        }
        public Client()
        {
            this.firstName = "";
            this.lastName = "";
            this.adres = "";
            this.phone = "";
        }
    }
}
