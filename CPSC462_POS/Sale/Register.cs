using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CPSC462_POS
{
    public class Register
    {
        private int id;
        private Sale sale;
        private Store store;
        private Cashier cashier;
        private int p;
        private CPSC462_POS.Store target;

        #region Properties

        public int Id
        {
            get { return id; }
        }

        public Sale Sale
        {
            get { return sale; }
        }

        public Store Store
        {
            get { return store; }
        }

        public Cashier Cashier
        {
            get { return cashier; }
        }

        #endregion

        #region Constructor

        public Register(int registerId, Store store, Cashier cashier)
        {
            this.id = registerId;
            this.store = store;
            this.cashier = cashier;
            createNewSale();
        }

        public Register(int registerId)
        {
            this.id = registerId;
            createNewSale();
        }

        public Register(int registerId, Store store)
        {
            this.id = registerId;
            this.store = store;
        }

        #endregion

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

        public void createNewSale()
        {
            if (this.sale != null && Sale.Payments.Count > 0)
                DBConnect.GetInstance.insertReceipt(this);

            sale = new Sale(store.TaxRate);
        }

        public void makePayment()
        {
            sale.createPayment();
        }

        public void printReceipt()
        {
            MessageBox.Show(sale.PrintReceipt());
        }
    }
}
