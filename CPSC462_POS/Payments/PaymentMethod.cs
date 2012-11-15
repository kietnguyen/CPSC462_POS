using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    public abstract class PaymentMethod
    {
        private decimal amount = 0;

        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public abstract void process();
    }
}
