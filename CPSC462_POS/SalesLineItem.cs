using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class SalesLineItem : Item
    {
        private int qty;

        public SalesLineItem(int product_id, int qty) : base(product_id)
        {
            this.qty = qty;
        }

        public void addQty(int qty)
        {
            this.qty += qty;
        }

        public void removeQty(int qyt)
        {
            this.qty -= qty;
        }

        public int getQty()
        {
            return this.qty;
        }

        // decimal is better for financial and monetary calculations
        // http://msdn.microsoft.com/en-us/library/364x0z75(v=vs.80).aspx
        public decimal getPrice()
        {
            return (decimal)this.qty * this.price;
        }
    }
}
