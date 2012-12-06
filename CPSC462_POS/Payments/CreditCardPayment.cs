using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    class CreditCardPayment : PaymentMethod
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
        
        public CreditCardPayment(decimal amount)
        {
            base.amount = amount;
        }

        public override bool process()
        {
            return new AuthorizeService("Credit Card Authorize Service").authorize();
        }

        public void process(int credit_card_no, int ccv, int month, int year)
        {

        }
    }
}
