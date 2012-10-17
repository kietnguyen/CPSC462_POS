using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class Item
    {
        private int id;
        private String name = "";
        private decimal price = 1m;

        public Item(int product_id)
        {
            this.id = product_id;

            //DB connect and get attribute values
            DBConnect db = new DBConnect();

            // hard code for different items
            //lookup item info from DB
            switch (product_id)
            { 
                case 1:
                    this.name = "Socks";
                    this.price = 11.8m;
                    break;
                case 2:
                    this.name = "Gum";
                    this.price = 3.5m;
                    break;
                case 3:
                    this.name = "Mustard";
                    this.price = 1.99m;
                    break;
                case 4:
                    this.name = "Ice";
                    this.price = 1.99m;
                    break;
                default:
                    this.name = "Misc";
                    this.price = 1m;
                    break;
            }

        }

        public Item(int id, String name, decimal price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        public decimal getPrice()
        {
            return this.price;
        }

        public void setPrice(decimal price)
        {
            this.price = price;
        }

        public String getName()
        {
            return this.name;
        }

        public int getID()
        {
            return this.id;
        }
    }
}
