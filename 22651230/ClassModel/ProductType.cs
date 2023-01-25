using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22651230.ClassModel
{
    public class ProductType
    {
        private string name;

        public ProductType(string name)
        {
            this.name = name;
        }
        public ProductType()
        {
            this.name = "";
        }
        public string Name { get => name; set => name = value; }
    }
}
