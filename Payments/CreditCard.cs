using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Payments
{
    class CreditCard : PaymentMethod
    {
        
        public override void process()
        { 

        }
        
        public void process(decimal amount, int credit_card_no, int ccv, int month, int year)
        {

        }
    }
}
