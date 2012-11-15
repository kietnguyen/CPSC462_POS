using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    public class SalesLineItem
    {
        private int qty;
        private ProductSpecification item;

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
            this.qty = qty;
            this.item = new ProductSpecification(product_id);
        }

        public SalesLineItem(ProductSpecification item, int qty)
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

        public ProductSpecification getItem()
        {
            return this.item;
        }

        public decimal getPrice()
        {
            return (decimal)this.qty * this.item.price;
        }
    }
}
