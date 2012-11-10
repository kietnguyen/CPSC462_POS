using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    public class Register
    {
        private int id;
        private Sale aSale;
        private Store store;
        private Cashier cashier;

        public int Id
        {
            get { return id; }
        }

        public Register(int registerId)
        {
            this.id = registerId;
        }


        public void voidItem()
        {

        }

        public void voidSale()
        { 
            // report to database
            createNewSale();
        }

        public void createNewSale()
        {
           aSale = new Sale(store.TaxRate);
        }


        public void makePayment()
        {
            aSale.createPayment();
        }

        public void printReceipt()
        {

        }
    }
}
