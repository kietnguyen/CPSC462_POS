using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class CheckPayment : PaymentMethod
    {
        public CheckPayment(decimal amount)
        {
            base.amount = amount;
        }

        public override bool process()
        {
            return new AuthorizeService("Check Authorize Service").authorize();
        }
    }
}
