using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22651230.ClassModel
{
    public class ShipmentPackage
    {
        private Product product;
        private int quantity;

        public Product Product { get => product; set => product = value; }
        public int Quantity { get => quantity; set => quantity = value; }

        public ShipmentPackage(Product product, int quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }
        public ShipmentPackage(int id, int quantity)
        {
            this.product.Id = id;
            this.quantity = quantity;
        }
        public ShipmentPackage()
        {
            
        }

    }
}
