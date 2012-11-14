using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
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
