using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    public class PaymentMethod
    {
        private Sale sale;
        public decimal amount
        {
            get
            {
                return sale.total;
            }
        }

        public void process(decimal amount)
        {
            
        }
    }
}
