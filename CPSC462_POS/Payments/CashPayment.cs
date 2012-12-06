using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class CashPayment : PaymentMethod
    {

        public CashPayment(decimal amount)
        {
            base.amount = amount;
        }
        
        public override bool process()
        {
            return true;
        }
    }
}
