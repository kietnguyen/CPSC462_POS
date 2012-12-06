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

<<<<<<< HEAD
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
=======
        public ProductSpecification(string name, string manufacture, string desc)
        {
            this.name = name;
            this.manufacture = manufacture;
            this.desc = desc;
>>>>>>> origin/newbranch
        }

    }
}
