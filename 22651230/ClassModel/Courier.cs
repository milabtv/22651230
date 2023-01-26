using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22651230.ClassModel
{
    public class Courier
    {
        private int id;
        private string firstName;
        private float price;

        public string FirstName { get => firstName; set => firstName = value; }
        public float Price { get => price; set => price = value; }
        public int Id { get => id; set => id = value; }

        public Courier(string firstName, float price,int id)
        {
            this.firstName = firstName;
            this.price = price;
            this.id = id;
        }
        public Courier(string firstName, int id)
        {
            this.firstName = firstName;
            this.id = id;
        }
        public Courier(string firstName, float price)
        {
            this.firstName = firstName;
            this.price = price;
        }
        public Courier(int id)
        {
            this.id = id;
        }
        public Courier()
        {
            this.firstName = "";
            this.price = 0;
            this.id = 0;
        }

    }
}