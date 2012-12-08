using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CPSC462_POS.UI
{
    public partial class FormPaymentMethod : Form, IFormPaymentMethodView
    {
        private Sale sale;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sale"></param>
        public FormPaymentMethod()
        {
            InitializeComponent();
        }

        #region Events implementation

        /// <summary>
        /// Handle payment when "Cash" button is clicked.
        /// </summary>
        /// <param name="sender">"Cash" button</param>
        /// <param name="e">Click event</param>
        private void cashBtn_Click(object sender, EventArgs e)
        {
            PayByCash();
        }

        /// <summary>
        /// Handle event when "Credit Card" button is clicked.
        /// </summary>
        /// <param name="sender">"Credit Card" button</param>
        /// <param name="e">Click event</param>
        private void creditCardBtn_Click(object sender, EventArgs e)
        {
            PayByCreditCard();
        }

        /// <summary>
        /// Handle event when "Check" button is clicked.
        /// </summary>
        /// <param name="sender">"Check" button</param>
        /// <param name="e">Click event</param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            PayByCheck();
        }

        #endregion

        #region IFormPaymentMethodView implementaton

        /// <summary>
        /// Assign "Payment Method" form for sale object
        /// </summary>
        /// <param name="sale"></param>
        public void SetSale(Sale sale)
        {
            this.sale = sale;
            lblBalanceNo.Text = sale.getBalance().ToString("C");
            this.Show();
        }

        /// <summary>
        /// Update "Payment Method" form view
        /// </summary>
        public void UpdatePaymentMethodView()
        {
            decimal balance = sale.getBalance();
            BalanceDisplay = balance.ToString("C");

            if (balance.ToString("C") == "$0.00")
            {
                this.Dispose();
                return;
            }

        }

        /// <summary>
        /// Implement PayByCash method
        /// </summary>
        public void PayByCash()
        {
            decimal balance = sale.getBalance();
            decimal amountEnter = Amount;
            decimal amount = (amountEnter > balance ? balance : amountEnter);
            PaymentMethod payment = new CashPayment(amount);

            if (amountEnter > balance)
            {
                decimal change = amountEnter - balance;
                MessageBox.Show("Your change is " + change.ToString("C"));
            }
            sale.processPayment(payment);
            UpdatePaymentMethodView();
        }

        /// <summary>
        /// Implement PayByCheck method
        /// </summary>
        public void PayByCheck()
        {
            decimal balance = sale.getBalance();
            decimal amountEnter = Amount;
            decimal amount = (amountEnter > balance ? balance : amountEnter);
            PaymentMethod payment = new CheckPayment(amount);

            if (amountEnter <= balance)
            {
                sale.processPayment(payment);
                UpdatePaymentMethodView();
            }
            else
                MessageBox.Show("Your check payment cannot be greater than your balance.");

        }

        /// <summary>
        /// Implement PayByCreditCard method
        /// </summary>
        public void PayByCreditCard()
        {
            decimal balance = sale.getBalance();
            decimal amountEnter = Amount;
            decimal amount = (amountEnter > balance ? balance : amountEnter);
            PaymentMethod payment = new CreditCardPayment(amount);

            if (amountEnter <= balance)
            {
                sale.processPayment(payment);
                UpdatePaymentMethodView();
            }
            else
                MessageBox.Show("Your credit card payment cannot be greater than your balance.");
 
        }

        /// <summary>
        /// Implement Balance amount displayed on the form
        /// </summary>
        public string BalanceDisplay
        {
            get { return sale.getBalance().ToString("C"); }
            set { lblBalanceNo.Text = value; }
        }

        /// <summary>
        /// Implement the amount user will pay
        /// </summary>
        public decimal Amount
        {
            get
            {
                decimal amount = 0;

                try
                {
                    amount = Convert.ToInt32(tbEnterAmount.Text);
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Amount must have a numerical format.", "Invalid amount");
                }
                finally
                {
                    tbEnterAmount.Text = "";
                }

                if (amount < 0)
                {
                    MessageBox.Show("Amount must have a positive value.", "Invalid amount");
                    tbEnterAmount.Text = "";
                }

                return amount;
            }
            set
            {
                tbEnterAmount.Text = value.ToString("C");
            }
        }

        #endregion
    }
}
