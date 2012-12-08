using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    public class ProductSpecification
    {
        private string name = "";
        private string manufacture = "";
        private string desc = "";

        public string Name { get { return name; } }
        public string Manufacture { get { return manufacture; } }
        public string Description { get { return desc; } }

        public ProductSpecification(string name, string manufacture, string desc)
        {
            this.name = name;
            this.manufacture = manufacture;
            this.desc = desc;
        }

    }
}
