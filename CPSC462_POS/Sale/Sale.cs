using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
<<<<<<< HEAD
=======
using CPSC462_POS.UI;
using System.Windows.Forms;
>>>>>>> origin/newbranch

namespace CPSC462_POS
{
    public class Sale
    {
<<<<<<< HEAD
        const decimal DEFAULT_TAX_RATE = 0.08m;
        private DateTime saleDate;
        private decimal taxRate = DEFAULT_TAX_RATE;
        private PaymentMethod payment;
=======
        private DateTime saleDate;
        private decimal taxRate;
        private List<PaymentMethod> payments;
        private Register register;
>>>>>>> origin/newbranch

        // change ArrayList to List: http://stackoverflow.com/questions/2309694/arraylist-vs-list-in-c-sharp
        private List<SalesLineItem> itemList;

        public DateTime SaleDate
<<<<<<< HEAD
        {
            get { return this.saleDate; }
        }

        public List<SalesLineItem> ItemList
        {
            get { return this.item_list; }
        }

        public Sale()
        {
            this.saleDate = DateTime.Now;
            this.taxRate = DEFAULT_TAX_RATE;
            this.item_list = new List<SalesLineItem>();
=======
        {
            get { return this.saleDate; }
>>>>>>> origin/newbranch
        }

        public List<SalesLineItem> ItemList
        {
<<<<<<< HEAD
            this.saleDate = DateTime.Now;
            this.taxRate = taxRate;
            this.item_list = new List<SalesLineItem>();
        }


=======
            get { return this.itemList; }
        }

        public List<PaymentMethod> Payments
        {
            get { return this.payments; }
        }

        public Sale()
        {
            this.saleDate = DateTime.Now;
            this.taxRate = 0m;
            this.itemList = new List<SalesLineItem>();
            this.payments = new List<PaymentMethod>();
        }

        public Sale(decimal taxRate)
        {
            this.saleDate = DateTime.Now;
            this.taxRate = taxRate;
            this.itemList = new List<SalesLineItem>();
            this.payments = new List<PaymentMethod>();
        }
>>>>>>> origin/newbranch

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public decimal getSubTotal()
        {
            decimal total = 0m;

            foreach (SalesLineItem lineItem in itemList)
            {
                total += lineItem.getPrice();
            }

            return total;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public decimal getTax()
        {
            return getSubTotal() * taxRate;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public decimal getTotal()
        {
            return getSubTotal() * (1 + taxRate);
        }

<<<<<<< HEAD
=======
        public decimal getBalance()
        {
            decimal balance = getTotal();
            foreach (PaymentMethod payment in payments)
            {
                balance -= payment.Amount;
            }
            return balance;
        }
>>>>>>> origin/newbranch

        /// <summary>
        /// Find sale line item matched with item Id.
        /// </summary>
        /// <param name="itemId">Item ID of the product. <see cref="T:Item"/></param>
        /// <returns>SalesLineItem-type variable matched the item Id</returns>
        private SalesLineItem findLineItem(int itemId)
        {
            foreach (SalesLineItem lineItem in itemList)
            {
                if (lineItem.getItem().ItemId == itemId)
                {
                    return lineItem;
                }
            }
            return null;
        }

        public void addItem(int itemId, int quantity)
        {
            SalesLineItem foundLineItem = findLineItem(itemId);
            if (foundLineItem == null)
            {
                if (quantity > 0)
                    itemList.Add(new SalesLineItem(itemId, quantity));
            }
            else
<<<<<<< HEAD
                foundLineItem.addQty(qty);
        }

        public void remove_item(int product_id, int qty)
=======
                foundLineItem.addQty(quantity);
        }

        /// <summary>
        /// Remove specified quantity of the sale line item matched with the item Id.
        /// </summary>
        /// <remarks>The sale line item will be removed if final quantity is less than or equal zero.</remarks>
        /// <param name="itemId"></param>
        /// <param name="quantity"></param>
        public void removeItem(int itemId, int quantity)
>>>>>>> origin/newbranch
        {
            SalesLineItem foundLineItem = findLineItem(itemId);
            if (foundLineItem == null) return;
            foundLineItem.removeQty(quantity);
            if (foundLineItem.getQty() <= 0) itemList.Remove(foundLineItem);

        }

<<<<<<< HEAD
        public void update_item(int product_id, int qty)
        {
            SalesLineItem foundLineItem = findLineItem(product_id);
=======
        /// <summary>
        /// Update quantity for itemId.
        /// </summary>
        /// <remarks>The sale line item will be removed if final quantity is less than or equal zero.</remarks>
        /// <param name="itemId">Item Id of product. <see cref="T:Item"/></param>
        /// <param name="quantity">Quantity of the product. </param>
        public void updateItem(int itemId, int quantity)
        {
            SalesLineItem foundLineItem = findLineItem(itemId);
>>>>>>> origin/newbranch
            if (foundLineItem == null) return;
            if (quantity <= 0)
                itemList.Remove(foundLineItem);
            else
                foundLineItem.setQty(quantity);
        }

<<<<<<< HEAD
=======
        /// <summary>
        /// 
        /// </summary>
        /// <param name="payment"></param>
        public void addPayment(PaymentMethod payment)
        {
            payments.Add(payment);
        }

        /// <summary>
        /// Create payment for a sale.
        /// <remarks>Detect wether there is still positive balance; if yes, create
        /// a new payment form so that user can choose what payment method he/she
        /// will use.</remarks>
        /// </summary>
>>>>>>> origin/newbranch
        public void createPayment()
        {
            if (this.getBalance() > 0)
                new FormPaymentMethod(this);
            else if (payments.Count > 0)
                MessageBox.Show("Payment is already made.");
        }

        /// <summary>
        /// Add payment to list of payments when it is authorized.
        /// </summary>
        /// <param name="payment">One of payment method: CashPayment, CheckPayment, or CreditCardPayment</param>
        public void processPayment(PaymentMethod payment)
        {
            if (payment.process())
                this.addPayment(payment);
        }
    }
}
