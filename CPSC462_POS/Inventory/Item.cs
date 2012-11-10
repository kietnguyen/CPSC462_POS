using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class Item
    {
        private string _serialNo = "";
        private ProductSpecification _productSpec;

        public string serialNo { get { return _serialNo; } }
        public string name { get { return _productSpec.name; } }
        public string description { get { return _productSpec.desc; } }
        public int id { get { return _productSpec.id; } }

        public Item()
        {

        }


    }
}
