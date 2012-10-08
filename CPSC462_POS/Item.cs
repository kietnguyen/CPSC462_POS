using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class Item
    {
        protected int id;
        protected String name = "";
        protected String desc = "";
        protected decimal price = 1m;

        public Item(int product_id)
        {
            this.id = product_id;

            //DB connect and get attribute values
            DBConnect db = new DBConnect();

        }

        public Item(int id, String name, string desc, decimal price)
        {
            this.id = id;
            this.name = name;
            this.desc = desc;
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

        public String getDesc()
        {
            return this.desc;
        }

        public int getID()
        {
            return this.id;
        }
    }
}
