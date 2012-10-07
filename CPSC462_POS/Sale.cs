using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CPSC462_POS
{
    class Sale
    {
        private string date;
        private string time;
        private decimal total;
        // change ArrayList to List: http://stackoverflow.com/questions/2309694/arraylist-vs-list-in-c-sharp
        private List<SalesLineItem> item_list = new List<SalesLineItem>();

        public void calculateTotal()
        {
            this.total = 0;
            if (item_list.Count > 0)
            {
                foreach (SalesLineItem lineItem in item_list)
                {
                    this.total += lineItem.getPrice();
                }
            }
        }

        public decimal getTotal()
        {
            return total;
        }

        public void add_item(int product_id, int qty)
        {
            Boolean found = false;
            foreach (SalesLineItem lineItem in item_list)
            {
                if (lineItem.getID() == product_id)
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

        public void remove_item(int product_id, int qty)
        {
            for (int i = 0; i < item_list.Count; i++)
            {
                if (item_list.IndexOf(i).getID() == product_id)
                {
                    item_list.IndexOf(i).removeQty(qty);
                    break;
                }
            }
        }
    }
}
