using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22651230.ClassModel
{
    public class Couriers
    {
        private string firstName;
        private float price;

        public string FirstName { get => firstName; set => firstName = value; }
        public float Price { get => price; set => price = value; }

        public Couriers(string firstName, float price)
        {
            this.firstName = firstName;
            this.price = price;
        }
        public Couriers()
        {
            this.firstName = "";
            this.price = 0;
        }

    }
}