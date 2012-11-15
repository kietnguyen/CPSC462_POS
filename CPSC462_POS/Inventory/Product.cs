using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    public class Product
    {
        private string serialNo = "";
        private ProductSpecification productSpec;

        public string SerialNo { get { return serialNo; } }
        public string Name { get { return productSpec.name; } }
        public string Description { get { return productSpec.desc; } }
        public int Id { get { return productSpec.id; } }

        public Product()
        {

        }


    }
}
