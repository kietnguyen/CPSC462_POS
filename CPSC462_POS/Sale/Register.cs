using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS
{
    public class Register
    {
        private int id;
        private Sale sale;
        private Store store;
        private Cashier cashier;

        public int Id
        {
            get { return id; }
        }

        public Sale Sale
        {
            get { return sale; }
        }

        public Register(int registerId, Store store)
        {
            this.id = registerId;
            this.store = store;
            createNewSale();
        }

        public Register(int registerId)
        {
            this.id = registerId;
            createNewSale();
        }

        public decimal getTaxRate()
        {
            return store.TaxRate;
        }

        public void addItem(int itemId, int quantity)
        {
            sale.addItem(itemId, quantity);
        }

        public void updateItem(int itemId, int quantity)
        {
            sale.updateItem(itemId, quantity);
        }

        public void voidItem(int itemId)
        {
            sale.updateItem(itemId, 0);
        }

        public void voidSale()
        {
            // report to database
            createNewSale();
        }

        public void createNewSale()
        {
            sale = new Sale(store.TaxRate);
        }


        public void makePayment()
        {
            sale.createPayment();
        }

        public void printReceipt()
        {

        }
    }
}
