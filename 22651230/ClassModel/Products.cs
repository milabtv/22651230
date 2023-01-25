using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22651230.ClassModel
{
    public class Products
    {
        private string prodName;
        private float price;

        public Products(string prodName, float price)
        {
            this.prodName = prodName;
            this.price = price;
        }
        public Products()
        {
            this.prodName = "";
            this.price = 0;
        }
        string ProdName { get => prodName; set => prodName = value; }
        public float Price { get => price; set => price = value; }
    }
}
