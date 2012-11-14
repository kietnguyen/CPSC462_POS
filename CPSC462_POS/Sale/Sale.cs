using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CPSC462_POS
{
    public class Sale
    {
        const decimal DEFAULT_TAX_RATE = 0.08m;
        private DateTime saleDate;
        private decimal taxRate = DEFAULT_TAX_RATE;
        private PaymentMethod payment;

        // change ArrayList to List: http://stackoverflow.com/questions/2309694/arraylist-vs-list-in-c-sharp
        private List<SalesLineItem> item_list;
        private int registerId;

        public DateTime SaleDate
        {
            get { return this.saleDate; }
        }

        public List<SalesLineItem> ItemList
        {
            get { return this.item_list; }
        }

        public Sale()
        {
            this.saleDate = DateTime.Now;
            this.taxRate = DEFAULT_TAX_RATE;
            this.item_list = new List<SalesLineItem>();
        }

        public Sale(decimal taxRate)
        {
            this.saleDate = DateTime.Now;
            this.taxRate = taxRate;
            this.item_list = new List<SalesLineItem>();
        }



        public decimal getSubTotal()
        {
            decimal total = 0m;

            foreach (SalesLineItem lineItem in item_list)
            {
                total += lineItem.getPrice();
            }

            return total;
        }

        public decimal getTax()
        {
            return getSubTotal() * taxRate;
        }

        public decimal getTotal()
        {
            return getSubTotal() * (1 + taxRate);
        }


        private SalesLineItem findLineItem(int product_id)
        {
            foreach (SalesLineItem lineItem in item_list)
            {
                if (lineItem.getItem().id == product_id)
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

        public void remove_item(int product_id, int qty)
        {
            SalesLineItem foundLineItem = findLineItem(product_id);
            if (foundLineItem == null) return;
            foundLineItem.removeQty(qty);
            if (foundLineItem.getQty() <= 0) item_list.Remove(foundLineItem);

        }

        public void update_item(int product_id, int qty)
        {
            SalesLineItem foundLineItem = findLineItem(product_id);
            if (foundLineItem == null) return;
            if (qty == 0)
                item_list.Remove(foundLineItem);
            else
                foundLineItem.setQty(qty);
        }

        public void createPayment()
        {

        }
    }
}
