using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    public class SalesLineItem
    {
        private int quantity;
        private Item item;

        public int Quantity
        { get { return quantity; } }

        public int ProductId
        { get { return item.ItemId; } }

        public string ProductName
        { get { return item.Name; } }

        public decimal ProductPrice
        { get { return item.Price; } }

        public decimal Subtotal
        { get { return quantity * item.Price; } }

        public int Quantity
        { get { return qty; } }

        public int ProductId
        { get { return item.id; } }

        public string ProductName
        { get { return item.name; } }

        public decimal ProductPrice
        { get { return item.price; } }

        public decimal Subtotal
        { get { return qty * item.price; } }

        public SalesLineItem(int product_id, int qty)
        {
            this.quantity = qty;
            this.item = DBConnect.GetInstance.retrieveItem(product_id);
        }

        public SalesLineItem(Item item, int qty)
        {
            this.item = item;
            this.quantity = qty;
        }

        public void addQty(int qty)
        {
            this.quantity += qty;
        }

        public void removeQty(int qty)
        {
            this.quantity -= qty;
        }

        public int getQty()
        {
            return this.quantity;
        }

        public void setQty(int qty)
        {
            this.quantity = qty;
        }

        public Item getItem()
        {
            return this.item;
        }

        public decimal getPrice()
        {
            return (decimal)this.quantity * this.item.Price;
        }
    }
}
