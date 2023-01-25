using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22651230.ClassModel
{
    public class Worker
    {
        private int id;
        private string firstName;
        private string lastName;
        private string phone;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public int ID { get => ID; set => ID = value; }

        public Worker(string firstName, string lastName, string phone,int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.id = id;
        }
        public Worker()
        {         
            this.firstName = "";
            this.lastName = "";
            this.phone = "";
            this.id = 0;
        }

        
    }
}
