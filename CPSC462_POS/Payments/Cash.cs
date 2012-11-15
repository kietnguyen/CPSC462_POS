using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class Cash : PaymentMethod
    {
        public Cash()
        {
            base.Amount = 0m;
        } 
        
        public Cash(decimal amount)
        {
            base.Amount = amount;
        }
        
        public override void process()
        {

        }
    }
}
