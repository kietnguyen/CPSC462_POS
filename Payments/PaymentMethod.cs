using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payments
{
    public abstract class PaymentMethod
    {
        private decimal _amount = 0;

        public decimal amount
        {
            get { return _amount; }
        }

        public abstract void process();
    }
}
