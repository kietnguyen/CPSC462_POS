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
    public partial class FormPOS : Form, IFormPOSView
    {
<<<<<<< HEAD
        private Register aRegister;

        public FormPOS()
        {
            InitializeComponent();
            aRegister = new Register(0);
            aRegister.createNewSale();
=======
        public FormPOS()
        {
            InitializeComponent();

            SetRegister(new Register(0,new Store("ABC","123 Abc St, ABC, CA 99999", 0.08m)));
>>>>>>> origin/newbranch
        }

        private Register register;

        #region Events implementation

        /** Handle event when user presses "Enter" or "Return" key in "Item #" text box. */
        private void tbItemNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {
<<<<<<< HEAD
                int itemId = textboxToPosInt(tbItemNo, "Item Id must be a positive integer.");
                int quantity = textboxToPosInt(tbQuantity, "Quatity must be a positive integer.", true);

                aRegister.addItem(itemId, quantity);
                updateLineItem();
=======
                if (tbItemNo.Text == "") return;
                AddLineItem();
>>>>>>> origin/newbranch
            }
        }

        /** Handle event when user presses "Enter" or "Return" key in "Quantity" text box. */
        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {
<<<<<<< HEAD
                int itemId = textboxToPosInt(tbItemNo, "Item Id must be a positive integer.");
                int quantity = textboxToPosInt(tbQuantity, "Quatity must be a positive integer.", true);

                if (dgItemLine.SelectedCells.Count > 0)
                    aRegister.updateItem(itemId, quantity);
                else
                    aRegister.addItem(itemId, quantity);
=======
                if (tbItemNo.Text == "") return;
                AddLineItem();
            }
        }

        /** Handle event when user clicks something on DataGridView area. */
        private void dgItemLine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /** Ignore when nothing is selected. */
            if (e.RowIndex < 0) return;
            SelectLineItem(e.RowIndex);
        }
>>>>>>> origin/newbranch

        /** Handle event when user clicks "Change Quantity" button. */
        private void btnChangeQuantity_Click(object sender, EventArgs e)
        {
            if (tbItemNo.Text == "") return;
            UpdateQuantity();
        }

<<<<<<< HEAD
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
=======
        /** Handle event when user clicks "Void Item" button. */
        private void btnItemVoid_Click(object sender, EventArgs e)
        {
            if (tbItemNo.Text == "") return;
            VoidLineItem();
        }

        /** Handle event when user clicks "Void Sale" button. */
        private void btnVoidSale_Click(object sender, EventArgs e)
        {
            VoidSale();
        }

        /** Handle event when user clicks "Make Payment" button. */
        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            MakePayment();
        }

        #endregion

        #region IFormPOSView implementation

        public void SetRegister(Register register)
        {
            this.register = register;
        }

        public void AddLineItem()
        {
            if (dgItemLine.SelectedCells.Count > 0)
                register.updateItem(ItemNoEnter, QuantityEnter);
            else
                register.addItem(ItemNoEnter, QuantityEnter);

            UpdateSaleView();
        }

        public void VoidLineItem()
        {
            /** This happens ONLY WHEN THERE IS AN ERROR. */
            if (ItemNoEnter == 0) return;
            register.voidItem(ItemNoEnter);
            UpdateSaleView();
        }
>>>>>>> origin/newbranch

        public void UpdateQuantity()
        {
            /** This happens ONLY WHEN THERE IS AN ERROR. */
            if (ItemNoEnter == 0) return;
            register.updateItem(ItemNoEnter, QuantityEnter);
            UpdateSaleView();
        }

        public void SelectLineItem(int index)
        {
            DataGridViewRow row = dgItemLine.Rows[index];
            tbItemNo.Text = row.Cells[0].Value.ToString();
            tbQuantity.Text = row.Cells[2].Value.ToString();
        }

        /// <summary>
        /// Update line item view in new-to-old order.
        /// Each line contains item number, name, quantity, unit price, and sub-total.
        /// </summary>
        public void UpdateSaleView()
        {
            /*
            dgItemLine.Rows.Clear();
<<<<<<< HEAD
            foreach (SalesLineItem lineItem in aRegister.Sale.ItemList.Reverse<SalesLineItem>())
            {
                ProductSpecification aItem = lineItem.getItem();
                dgItemLine.Rows.Add(aItem.id, aItem.name, lineItem.getQty(),
                                    aItem.price.ToString("C"), lineItem.getPrice().ToString("C"));
            }
            tbSubtotal.Text = aRegister.Sale.getSubTotal().ToString("C");
            tbTax.Text = aRegister.Sale.getTax().ToString("C");
            tbTotal.Text = aRegister.Sale.getTotal().ToString("C");

            dgItemLine.ClearSelection();*/
=======
            foreach (SalesLineItem lineItem in register.Sale.ItemList.Reverse<SalesLineItem>())
            {
                Item anItem = lineItem.getItem();

                if (anItem == null) break;

                dgItemLine.Rows.Add(anItem.ItemId, anItem.Name, lineItem.getQty(),
                                    anItem.Price.ToString("C"), lineItem.getPrice().ToString("C"));
            }
            dgItemLine.ClearSelection();

            tbSubtotal.Text = SubTotalDisplay;
            tbTax.Text = TaxDisplay;
            tbTotal.Text = TotalDisplay;
>>>>>>> origin/newbranch
        }

        /// <summary>
        /// 
        /// </summary>
        public void VoidSale()
        {
            register.voidSale();
            UpdateSaleView();
        }

        /// <summary>
        /// 
        /// </summary>
        public void MakePayment()
        {
<<<<<<< HEAD
            int itemId = textboxToPosInt(tbItemNo, "Item Id must be a positive integer.");
            int quantity = textboxToPosInt(tbQuantity, "Quatity must be a positive integer.", true);

            aRegister.Sale.update_item(itemId, quantity);
            updateLineItem();
=======
            register.makePayment();
            UpdateSaleView();
        }

        /// <summary>
        /// 
        /// </summary>
        public void PrintReceipt()
        {
            register.printReceipt();
            UpdateSaleView();
>>>>>>> origin/newbranch
        }

        /** Integer value in "Item #" text box. */
        public int ItemNoEnter
        {
            get
            {
                return TextBoxParser.GetInstance.tbToPosInt(tbItemNo, "Item Id must be a positive integer.");
            }
            set
            {
                ItemNoEnter = TextBoxParser.GetInstance.tbToPosInt(tbItemNo, "Item Id must be a positive integer.");
            }
        }

        /** Integer value in "Quantity" text box. */
        public int QuantityEnter
        {
<<<<<<< HEAD
            int itemId = textboxToPosInt(tbItemNo, "Item Id must be a positive integer.");
            int quantity = textboxToPosInt(tbQuantity, "Quatity must be a positive integer.", true);

            aRegister.Sale.remove_item(itemId, quantity);
            updateLineItem();
=======
            get
            {
                return TextBoxParser.GetInstance.tbToPosInt(tbQuantity, "Quatity must be a positive integer.", true);
            }
            set
            {
                QuantityEnter = TextBoxParser.GetInstance.tbToPosInt(tbQuantity, "Quatity must be a positive integer.", true);
            }
        }

        /** Value in "Subtotal" text box in Currency string format. */
        public string SubTotalDisplay
        {
            get
            {
                return register.Sale.getSubTotal().ToString("C");
            }
>>>>>>> origin/newbranch
        }

        /** Value in "Tax" text box in Currency string format. */
        public string TaxDisplay
        {
            get
            {
                return register.Sale.getTax().ToString("C");
            }
        }

        /** Value in "Total" text box in Currency string format. */
        public string TotalDisplay
        {
            get
            {
                return register.Sale.getTotal().ToString("C");
            }
        }

        #endregion 
    }
}
