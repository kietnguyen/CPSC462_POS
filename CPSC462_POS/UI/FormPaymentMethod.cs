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
        private Register register;

        public FormPaymentMethod(Register aRegister)
        {
            InitializeComponent();
            register = aRegister;
        }

        private void cashBtn_Click(object sender, EventArgs e)
        {
            register.Sale.Payment = new Cash();
            register.makePayment();
        }

        private void creditCardBtn_Click(object sender, EventArgs e)
        {
            register.Sale.Payment = new CreditCard();
            register.makePayment();
        }
    }
}
