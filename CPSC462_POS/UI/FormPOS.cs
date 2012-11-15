using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CPSC462_POS.UI;

namespace CPSC462_POS
{
    public partial class FormPOS : Form
    {
        private Register aRegister;
        Form paymentForm;

        public FormPOS()
        {
            InitializeComponent();

            aRegister = new Register(0);
            aRegister.createNewSale();

            paymentForm = new FormPaymentMethod(aRegister);
        }

        private void tbItemNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {
                if (tbItemNo.Text == "") return;
                int itemId = textboxToPosInt(tbItemNo, "Item Id must be a positive integer.");
                int quantity = textboxToPosInt(tbQuantity, "Quatity must be a positive integer.", true);

                aRegister.addItem(itemId, quantity);
                updateLineItem();
            }
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {
                if (tbItemNo.Text == "") return;
                int itemId = textboxToPosInt(tbItemNo, "Item Id must be a positive integer.");
                int quantity = textboxToPosInt(tbQuantity, "Quatity must be a positive integer.", true);

                if (dgItemLine.SelectedCells.Count > 0)
                    aRegister.updateItem(itemId, quantity);
                else
                    aRegister.addItem(itemId, quantity);

                updateLineItem();
            }
        }

        private int textboxToPosInt(TextBox tb, string errMessage, bool defaultOne = false)
        {
            int num = 0;
            tb.Text = ((defaultOne & tb.Text == "") ? "1" : tb.Text);

            try
            {
                num = Convert.ToInt32(tb.Text);
                tb.Clear();
            }
            catch (FormatException e)
            {
                if (errMessage.Length > 0)
                    MessageBox.Show(e.Message);
                else throw e;
            }

            if (num <= 0) throw new Exception(errMessage);

            return num;
        }

        private void updateLineItem()
        {
            
            dgItemLine.Rows.Clear();
            foreach (SalesLineItem lineItem in aRegister.Sale.ItemList.Reverse<SalesLineItem>())
            {
                ProductSpecification aItem = lineItem.getItem();
                dgItemLine.Rows.Add(aItem.id, aItem.name, lineItem.getQty(),
                                    aItem.price.ToString("C"), lineItem.getPrice().ToString("C"));
            }
            tbSubtotal.Text = aRegister.Sale.getSubTotal().ToString("C");
            tbTax.Text = aRegister.Sale.getTax().ToString("C");
            tbTotal.Text = aRegister.Sale.getTotal().ToString("C");

            dgItemLine.ClearSelection();

        }

        private void dgItemLine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgItemLine.Rows[e.RowIndex];
            tbItemNo.Text = row.Cells[0].Value.ToString();
            tbQuantity.Text = row.Cells[2].Value.ToString();
        }

        private void btnChangeQuantity_Click(object sender, EventArgs e)
        {
            int itemId = textboxToPosInt(tbItemNo, "Item Id must be a positive integer.");
            int quantity = textboxToPosInt(tbQuantity, "Quatity must be a positive integer.", true);

            aRegister.Sale.update_item(itemId, quantity);
            updateLineItem();
        }


        private void btnItemVoid_Click(object sender, EventArgs e)
        {
            int itemId = textboxToPosInt(tbItemNo, "Item Id must be a positive integer.");
            int quantity = textboxToPosInt(tbQuantity, "Quatity must be a positive integer.", true);

            aRegister.Sale.remove_item(itemId, quantity);
            updateLineItem();
        }

        private void btnVoidSale_Click(object sender, EventArgs e)
        {
            aRegister.voidSale();
            updateLineItem();
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            paymentForm.Show();
        }



    }
}
