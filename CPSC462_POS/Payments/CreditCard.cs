using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class CreditCard : PaymentMethod
    {
        private string name;
        private int month;
        private int year;
        private Int64 number;
        private int ccv;

        private string Name
        {
            set { name = value.Trim().ToUpper(); }
        }
        
        public CreditCard()
        {
            base.Amount = 0m;
        }
        
        public CreditCard(decimal amount)
        {
            base.Amount = amount;
        }

        public override void process()
        {

        }

        public void process(int credit_card_no, int ccv, int month, int year)
        {

        }
    }
}
