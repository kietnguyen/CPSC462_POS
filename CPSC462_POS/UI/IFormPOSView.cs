using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPSC462_POS.UI
{
    interface IFormPOSView
    {
        void SetRegister(Register register);
        void AddLineItem();
        void VoidLineItem();
        void UpdateQuantity();
        void SelectLineItem(int index);
        void UpdateSaleView();
        void VoidSale();
        void MakePayment();
        void PrintReceipt();

        int ItemNoEnter { get; set; }
        int QuantityEnter { get; set; }
        string SubTotalDisplay { get; }
        string TaxDisplay { get; }
        string TotalDisplay { get; }
    }
}
