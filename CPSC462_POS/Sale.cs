using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CPSC462_POS
{
    class Sale
    {
        private DateTime date;
        private decimal tax;
        // change ArrayList to List: http://stackoverflow.com/questions/2309694/arraylist-vs-list-in-c-sharp
        private List<SalesLineItem> item_list;

        public Sale()
        {
            date = DateTime.Now;
            tax = 0;
            item_list = new List<SalesLineItem>();
        }

        public decimal getSubTotal()
        {
            decimal total = 0;

            foreach (SalesLineItem lineItem in item_list)
            {
                total += lineItem.getPrice();
            }

            return total;
        }

        public decimal getTax()
        {
            return getSubTotal() * this.tax;
        }

        public decimal getTotal()
        {
            return getSubTotal() * (1 + this.tax);
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
            Boolean found = false;
            foreach (SalesLineItem lineItem in item_list)
            {
                if (lineItem.getItem().getID() == product_id)
                {
                    lineItem.addQty(qty);
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                item_list.Add(new SalesLineItem(product_id, qty));
            }
        }

        public void add_item(SalesLineItem lineItem)
        {
            if (lineItem == null) return;
            add_item(lineItem.getItem().getID(), lineItem.getQty());
        }

        public void remove_item(int product_id, int qty)
        {
            foreach (SalesLineItem lineItem in item_list)
            {
                if (lineItem.getItem().getID() == product_id)
                {
                    lineItem.removeQty(qty);
                    if (lineItem.getQty() <= 0)
                        item_list.Remove(lineItem);
                    break;
                }
            }
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
