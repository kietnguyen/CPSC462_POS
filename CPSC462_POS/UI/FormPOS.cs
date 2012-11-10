using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CPSC462_POS
{
    public partial class FormPOS : Form
    {
        private Register aRegister;
        private Sale aSale;

        public FormPOS()
        {
            InitializeComponent();
            aRegister = new Register(0);
            aRegister.createNewSale();
            aSale = aRegister.Sale;
        }

        private void tbItemNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {
                int itemId = textboxToPosInt(tbItemNo, "Item Id must be a positive integer.");
                int quantity = textboxToPosInt(tbQuantity, "Quatity must be a positive integer.");

                aSale.add_item(itemId, quantity);
                updateLineItem();
            }
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {
                int itemId = textboxToPosInt(tbItemNo, "Item Id must be a positive integer.");
                int quantity = textboxToPosInt(tbQuantity, "Quatity must be a positive integer.");

                if (dgItemLine.SelectedCells.Count > 0)
                    aSale.update_item(itemId, quantity);
                else
                    aSale.add_item(itemId, quantity);

                updateLineItem();
            }
        }

        private int textboxToPosInt(TextBox tb, string errMessage)
        {
            int num = 0;

            try
            {
                num = Convert.ToInt32(tb.Text);
                tb.Clear();
            }
            catch (FormatException e)
            {
                if (errMessage.Length == 0)
                    MessageBox.Show(e.Message);
                else throw e;
            }

            if (num <= 0) throw new Exception(errMessage);

            return num;
        }

        private void updateLineItem()
        {
            dgItemLine.Rows.Clear();
            foreach (SalesLineItem lineItem in aSale.getItems())
            {
                ProductSpecification aItem = lineItem.getItem();
                dgItemLine.Rows.Add(aItem.id, aItem.name, lineItem.getQty(),
                                    aItem.price.ToString("C"), lineItem.getPrice().ToString("C"));
            }
            tbSubtotal.Text = aSale.getSubTotal().ToString("C");
            tbTax.Text = aSale.getTax().ToString("C");
            tbTotal.Text = aSale.getTotal().ToString("C");

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
            int quantity = textboxToPosInt(tbQuantity, "Quatity must be a positive integer.");

            aSale.update_item(itemId, quantity);
            updateLineItem();
        }


        private void btnItemVoid_Click(object sender, EventArgs e)
        {
            int itemId = textboxToPosInt(tbItemNo, "Item Id must be a positive integer.");
            int quantity = textboxToPosInt(tbQuantity, "Quatity must be a positive integer.");

            aSale.remove_item(itemId, quantity);
            updateLineItem();
        }

        private void btnVoidSale_Click(object sender, EventArgs e)
        {
            aRegister.voidSale();
            updateLineItem();
        }

        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            aRegister.makePayment();
        }

    }
}
