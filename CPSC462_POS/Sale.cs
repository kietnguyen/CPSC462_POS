using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CPSC462_POS
{
    class Sale
    {
        const decimal DEFAULT_TAX_RATE = 0.08m;
        private DateTime date;
        private decimal taxRate = DEFAULT_TAX_RATE;

        // change ArrayList to List: http://stackoverflow.com/questions/2309694/arraylist-vs-list-in-c-sharp
        private List<SalesLineItem> item_list;
        private int registerId;

        public decimal subTotal
        {
            get
            {
                decimal total = 0m;

                foreach (SalesLineItem lineItem in item_list)
                {
                    total += lineItem.getPrice();
                }

                return total;
            }
        }

        public decimal total
        {
            get
            {
                return this.subTotal * (1 + taxRate);
            }
        }

        public decimal tax
        {
            get
            {
                return this.subTotal * this.taxRate;
            }
        }

        public Sale()
        {
            this.date = DateTime.Now;
            this.taxRate = DEFAULT_TAX_RATE;
            this.item_list = new List<SalesLineItem>();
        }

        public Sale(decimal taxRate)
        {
            this.date = DateTime.Now;
            this.taxRate = taxRate;
            this.item_list = new List<SalesLineItem>();
        }

        public DateTime getSaleDate()
        {
            return this.date;
        }

        public decimal getSubTotal(){
            return this.subTotal;
        }

        public decimal getTax()
        {
            return this.tax;
        }

        public decimal getTotal()
        {
            return this.total;
        }

        public List<SalesLineItem> getItems()
        {
            return this.item_list;
        }

        private SalesLineItem findLineItem(int product_id)
        {
            foreach (SalesLineItem lineItem in item_list)
            {
                if (lineItem.getItem().getID() == product_id)
                {
                    return lineItem;
                }
            }
            return null;
        }

        public void add_item(int product_id, int qty)
        {
            SalesLineItem foundLineItem = findLineItem(product_id);
            if (foundLineItem == null)
            {
                if (qty > 0)
                    item_list.Add(new SalesLineItem(product_id, qty));
            }
            else
                foundLineItem.addQty(qty);
        }

        public void add_item(SalesLineItem lineItem)
        {
            if (lineItem == null) return;
            add_item(lineItem.getItem().getID(), lineItem.getQty());
        }

        public void remove_item(int product_id, int qty)
        {
            SalesLineItem foundLineItem = findLineItem(product_id);
            if (foundLineItem == null) return;
            foundLineItem.removeQty(qty);
            if (foundLineItem.getQty() <= 0) item_list.Remove(foundLineItem);

        }

        public void remove_item(SalesLineItem lineItem)
        {
            if (lineItem == null) return;
            remove_item(lineItem.getItem().getID(), lineItem.getQty());
        }

        public void update_item(SalesLineItem lineItem)
        {
            if (lineItem == null) return;
            SalesLineItem foundLineItem = findLineItem(lineItem.getItem().getID());
            if (foundLineItem == null) return;
            if (lineItem.getQty() == 0)
                item_list.Remove(foundLineItem);
            else
                foundLineItem.setQty(lineItem.getQty());
        }
    }
}
