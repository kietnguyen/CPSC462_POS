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

        public Sale Sale
        {
            get { return aSale; }
        }

        public void addItem(int itemId, int quantity)
        {
            aSale.add_item(itemId, quantity);
        }

        public void updateItem(int itemId, int quantity)
        {
            aSale.update_item(itemId, quantity);
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
            aSale = new Sale();
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
