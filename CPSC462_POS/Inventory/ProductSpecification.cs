using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class ProductSpecification
    {
        private int _id;
        private string _name = "";
        private string _desc = "";
        private decimal _price = 1m;

        public int id { get { return _id; } }
        public string name { get { return _name; } }
        public string desc { get { return _desc; } }
        public decimal price { get { return _price; } }

        public ProductSpecification()
        {
        }

        public ProductSpecification(int product_id)
        {
            this._id = product_id;

            //DB connect and get attribute values
            DBConnect db = new DBConnect();

            // hard code for different items
            //lookup item info from DB
            switch (product_id)
            {
                case 1:
                    this._name = "Socks";
                    this._price = 11.8m;
                    break;
                case 2:
                    this._name = "Gum";
                    this._price = 3.5m;
                    break;
                case 3:
                    this._name = "Mustard";
                    this._price = 1.99m;
                    break;
                case 4:
                    this._name = "Ice";
                    this._price = 1.99m;
                    break;
                default:
                    this._name = "Misc";
                    this._price = 1m;
                    break;
            }

        }

        public ProductSpecification(int id, string name, string desc, decimal price)
        {
            this._id = id;
            this._name = name;
            this._desc = desc;
            this._price = price;
        }

    }
}
