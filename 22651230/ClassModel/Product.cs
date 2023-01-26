using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22651230.ClassModel
{
    public class Product
    {
        private int id;
        private string prodName;
        private float price;
        private int quantity;
        private ProductType productType;

        public Product(string prodName, float price, int quantity, ProductType productType, int id)
        {
            this.prodName = prodName;
            this.price = price;
            this.quantity = quantity;
            this.productType = productType;
            this.id = id;
        }
        public Product(string prodName, float price, int quantity, ProductType productType)
        {
            this.prodName = prodName;
            this.price = price;
            this.quantity = quantity;
            this.productType = productType;
        }
        public Product(string prodName, int id)
        {
            this.prodName = prodName; 
            this.id = id;
        }
        public Product(int id)
        {
            this.id = id;
        }
        public Product()
        {
            
        }
        public string ProdName { get => prodName; set => prodName = value; }
        public float Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public ProductType ProductType { get => productType; set => productType = value; }
        public int Id { get => Id; set => Id = value; }
    }
}
