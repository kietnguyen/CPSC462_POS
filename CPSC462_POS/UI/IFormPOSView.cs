using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CPSC462_POS.UI
{
    interface IFormPOSView
    {
        void setRegister(Register register);
        void createNewSale();
        void addLineItem();
        void voidLineItem();
        void updateQuantity();
        void selectLineItem(int index);
        void updateSaleView();
        void makePayment();
        void printReceipt();

        int ItemNoEnter { get; set; }
        int QuantityEnter { get; set; }
        string SubTotalDisplay { get; }
        string TaxDisplay { get; }
        string TotalDisplay { get; }
        string DateDisplay { get; }
        string BalanceDisplay { get; }
    }
}
