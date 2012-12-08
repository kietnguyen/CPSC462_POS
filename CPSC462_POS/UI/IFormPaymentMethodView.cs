using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS.UI
{
    interface IFormPaymentMethodView
    {
        void SetSale(Sale sale);
        void UpdatePaymentMethodView();
        void PayByCash();
        void PayByCheck();
        void PayByCreditCard();

        string BalanceDisplay { get; }
        decimal Amount { get; set; }
    }
}
