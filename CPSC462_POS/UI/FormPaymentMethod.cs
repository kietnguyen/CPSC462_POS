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
    public partial class FormPaymentMethod : Form
    {
        private Sale sale;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sale"></param>
        public FormPaymentMethod(Sale sale)
        {
            InitializeComponent();
            this.sale = sale;

            lblBalanceNo.Text = sale.getTotal().ToString("C");
            this.ShowDialog();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cashBtn_Click(object sender, EventArgs e)
        {
            decimal amount = TextBoxParser.GetInstance.tbToPosDecimal(tbEnterAmount);
            if (amount == 0) return;

            PaymentMethod payment = new CashPayment(amount);

            sale.processPayment(payment);
            UpdatePaymentMethodView();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void creditCardBtn_Click(object sender, EventArgs e)
        {
            decimal amount = TextBoxParser.GetInstance.tbToPosDecimal(tbEnterAmount);
            if (amount == 0) return;

            PaymentMethod payment = new CreditCardPayment(amount);

            if (amount <= sale.getBalance())
            {
                sale.processPayment(payment);
                UpdatePaymentMethodView();
            }
            else
                MessageBox.Show("Your credit card payment cannot be greater than your balance.");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheck_Click(object sender, EventArgs e)
        {
            decimal amount = TextBoxParser.GetInstance.tbToPosDecimal(tbEnterAmount);
            if (amount == 0) return;

            PaymentMethod payment = new CheckPayment(amount);

            if (amount <= sale.getBalance())
            {
                sale.processPayment(payment);
                UpdatePaymentMethodView();
            }
            else
                MessageBox.Show("Your check payment cannot be greater than your balance.");


        }

        private void UpdatePaymentMethodView()
        {
            decimal balance = sale.getBalance();
            lblBalanceNo.Text = balance.ToString("C");
            
            if (balance.Equals(0))
                this.Close();

            if (balance < 0m)
            {
                MessageBox.Show("Your change is " + (-balance).ToString("C"));
                this.Close();
            }
        }

    }
}
