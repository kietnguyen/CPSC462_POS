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
        private Sale aSale;

        public FormPOS()
        {
            InitializeComponent();
            aSale = new Sale();
        }

        private void tbItemNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {
                aSale.add_item(getSalesLineItemFromForm());
                updateLineItem();
            }
        }

        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {
                if (dgItemLine.SelectedCells.Count > 0)
                    aSale.update_item(getSalesLineItemFromForm());
                else
                    aSale.add_item(getSalesLineItemFromForm());
                updateLineItem();
            }
        }

        private SalesLineItem getSalesLineItemFromForm()
        {
            int itemNo = 0;
            int quantity = 0;

            if (tbItemNo.Text == "") return null;

            try
            {
                quantity = Convert.ToInt32(tbQuantity.Text == "" ? "1" : tbQuantity.Text);
                tbQuantity.Clear();
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

            try
            {
                itemNo = Convert.ToInt32(tbItemNo.Text);
                tbItemNo.Clear();
            }
            catch (FormatException e)
            {
                MessageBox.Show(e.Message);
                return null;
            }

            return new SalesLineItem(itemNo, quantity);
        }

        private void updateLineItem()
        {
            dgItemLine.Rows.Clear();
            foreach (SalesLineItem lineItem in aSale.getItems())
            {
                Item aItem = lineItem.getItem();
                dgItemLine.Rows.Add(aItem.getID(), aItem.getDesc(), lineItem.getQty(),
                                    aItem.getPrice().ToString("C"), lineItem.getPrice().ToString("C"));
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
            aSale.update_item(getSalesLineItemFromForm());
            updateLineItem();
        }


        private void btnItemVoid_Click(object sender, EventArgs e)
        {
            aSale.remove_item(getSalesLineItemFromForm());
            updateLineItem();
        }

        private void btnVoidSale_Click(object sender, EventArgs e)
        {
            aSale = new Sale();
            updateLineItem();
        }



    }
}
