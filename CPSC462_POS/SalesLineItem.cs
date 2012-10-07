using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class SalesLineItem
    {
        private int qty {set; get;}
        private Item item;

        public SalesLineItem()
        {
            this.qty = 0;
            this.item = null;
        }

        public SalesLineItem(int product_id, int qty)
        {
            this.qty = qty;
            this.item = new Item(product_id);
            // database query
        }

        public SalesLineItem(Item item, int qty)
        {
            this.item = item;
            this.qty = qty;
        }

        public void addQty(int qty)
        {
            this.qty += qty;
        }

        public void removeQty(int qty)
        {
            this.qty -= qty;
        }

        public int getQty()
        {
            return this.qty;
        }

        public void setQty(int qty)
        {
            this.qty = qty;
        }

        public Item getItem()
        {
            return this.item;
        }

        // decimal is better for financial and monetary calculations
        // http://msdn.microsoft.com/en-us/library/364x0z75(v=vs.80).aspx
        public decimal getPrice()
        {
            return (decimal)this.qty * this.item.getPrice();
        }
    }
}
