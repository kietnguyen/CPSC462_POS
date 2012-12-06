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

<<<<<<< HEAD
        public Sale Sale
        {
            get { return aSale; }
=======
        public decimal getTaxRate()
        {
            return store.TaxRate;
>>>>>>> origin/newbranch
        }

        public void addItem(int itemId, int quantity)
        {
<<<<<<< HEAD
            aSale.add_item(itemId, quantity);
        }

        public void updateItem(int itemId, int quantity)
        {
            aSale.update_item(itemId, quantity);
=======
            sale.addItem(itemId, quantity);
>>>>>>> origin/newbranch
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
<<<<<<< HEAD
            aSale = new Sale();
=======
            sale = new Sale(store.TaxRate);
>>>>>>> origin/newbranch
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
