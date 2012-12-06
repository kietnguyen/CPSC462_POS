using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    public abstract class PaymentMethod
    {
        protected decimal amount = 0;

        public decimal Amount
        {
            get { return amount; }
        }

        public abstract bool process();
    }
}
