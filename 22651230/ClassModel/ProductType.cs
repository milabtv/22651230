using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22651230.ClassModel
{
    public class ProductType
    {
        private int id;
        private string name;

        public ProductType(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public ProductType()
        {
            this.name = "";
            this.id = 0;
        }
        public string Name { get => name; set => name = value; }
        public int Id { get => id; set => id = value; }
    }
}
