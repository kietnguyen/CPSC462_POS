using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class SalesLineItem
    {
        private int qty;
        private ProductSpecification item;

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
