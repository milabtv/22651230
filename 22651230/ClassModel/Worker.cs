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
        public int ID { get => id; set => id = value; }

        public Worker(string firstName, string lastName, string phone,int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.id = id;
        }
        public Worker(string firstName, string lastName, int id)
        {
            this.firstName = firstName;
            this.lastName = lastName;;
            this.id = id;
        }
        public Worker(string firstName, string lastName, string phone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
        }
        public Worker( int id)
        {
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
