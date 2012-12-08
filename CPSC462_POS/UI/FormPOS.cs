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
        public FormPOS()
        {
            InitializeComponent();

            Store store = new Store(1, "ABC","123 Abc St, ABC, CA 99999", 0.08m);
            Cashier cashier = new Cashier(store, 1, 1200m, "CashierA", "", "1/1/1988", "123 Abc St, ABC, CA 99999");
            setRegister(new Register(1, store, cashier));
        }

        private Register register;

        #region Events implementation

        /** Handle event when user presses "Enter" or "Return" key in "Item #" text box. */
        private void tbItemNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter) 
                && (tbItemNo.Text.Length > 0))
            {
                addLineItem();
            }
        }

        /** Handle event when user presses "Enter" or "Return" key in "Quantity" text box. */
        private void tbQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
                 && (tbQuantity.Text.Length > 0))
            {
                addLineItem();
            }
        }

        /** Handle event when user clicks something on DataGridView area. */
        private void dgItemLine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /** Ignore when nothing is selected. */
            if (e.RowIndex < 0) return;
            selectLineItem(e.RowIndex);
        }

        /** Handle event when user clicks "Change Quantity" button. */
        private void btnChangeQuantity_Click(object sender, EventArgs e)
        {
            if (tbItemNo.Text == "") return;
            updateQuantity();
        }

        /** Handle event when user clicks "Void Item" button. */
        private void btnItemVoid_Click(object sender, EventArgs e)
        {
            if (tbItemNo.Text == "") return;
            voidLineItem();
        }

        /** Handle event when user clicks "Make Payment" button. */
        private void btnMakePayment_Click(object sender, EventArgs e)
        {
            makePayment();
        }

        /// <summary>
        /// Handle event when user clicks "Print Receipt" button.
        /// </summary>
        /// <param name="sender">"Print Receipt" button</param>
        /// <param name="e">Click event</param>
        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            printReceipt();
        }

        /// <summary>
        /// Handle event when user are done with "Payment Method" form
        /// </summary>
        /// <param name="sender">POS form</param>
        /// <param name="e">Activate event</param>
        private void FormPOS_Activated(object sender, EventArgs e)
        {
            updateSaleView();
        }

        private void btnNewSale_Click(object sender, EventArgs e)
        {
            createNewSale();
        }

        #endregion

        #region IFormPOSView implementation

        public void setRegister(Register register)
        {
            this.register = register;
        }

        public void createNewSale()
        {
            register.createNewSale();
            updateSaleView();
        }

        public void addLineItem()
        {
            if (dgItemLine.SelectedCells.Count > 0)
                register.updateItem(ItemNoEnter, QuantityEnter);
            else
                register.addItem(ItemNoEnter, QuantityEnter);

            updateSaleView();
        }

        public void voidLineItem()
        {
            /** This happens ONLY WHEN THERE IS AN ERROR. */
            if (ItemNoEnter == 0) return;
            register.voidItem(ItemNoEnter);
            updateSaleView();
        }

        public void updateQuantity()
        {
            /** This happens ONLY WHEN THERE IS AN ERROR. */
            if (ItemNoEnter == 0) return;
            register.updateItem(ItemNoEnter, QuantityEnter);
            updateSaleView();
        }

        public void selectLineItem(int index)
        {
            DataGridViewRow row = dgItemLine.Rows[index];
            tbItemNo.Text = row.Cells[0].Value.ToString();
            tbQuantity.Text = row.Cells[2].Value.ToString();
        }

        /// <summary>
        /// Update line item view in new-to-old order.
        /// Each line contains item number, name, quantity, unit price, and sub-total.
        /// </summary>
        public void updateSaleView()
        {
            dgItemLine.Rows.Clear();
            foreach (SalesLineItem lineItem in register.Sale.ItemList.Reverse<SalesLineItem>())
            {
                Item anItem = lineItem.getItem();

                if (anItem == null) break;

                dgItemLine.Rows.Add(anItem.ItemId, anItem.Name, lineItem.getQty(),
                                    anItem.Price.ToString("C"), lineItem.getPrice().ToString("C"));
            }
            dgItemLine.ClearSelection();

            lblSubTotalVal.Text = SubTotalDisplay;
            lblTaxVal.Text = TaxDisplay;
            lblTotalVal.Text = TotalDisplay;
            lblBalanceDueVal.Text = BalanceDisplay;
            lblSaleDateVal.Text = DateDisplay;
        }

        /// <summary>
        /// 
        /// </summary>
        public void makePayment()
        {
            register.makePayment();
            updateSaleView();
        }

        /// <summary>
        /// 
        /// </summary>
        public void printReceipt()
        {
            register.printReceipt();
            updateSaleView();
        }

        /** Integer value in "Item #" text box. */
        public int ItemNoEnter
        {
            get
            {
                int num = 0;

                try
                {
                    num = Convert.ToInt32(tbItemNo.Text);
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Item number must have a numerical format.", "Invalid item number");
                }
                finally
                {
                    tbItemNo.Text = "";
                }

                if (num < 0)
                {
                    MessageBox.Show("Item number must have a positive value.", "Invalid item number");
                    tbItemNo.Text = "";
                }

                return num;
            }
            set
            {
                tbItemNo.Text = value.ToString("D10");
            }
        }

        /** Integer value in "Quantity" text box. */
        public int QuantityEnter
        {
            get
            {
                int num = 0;
                if (tbQuantity.Text == "")
                {
                    tbQuantity.Text = "1";
                }

                try
                {
                    num = Convert.ToInt32(tbQuantity.Text);
                }
                catch (FormatException fe)
                {
                    MessageBox.Show("Quantity must have a numerical format.", "Invalid quantity");
                }
                finally
                {
                    tbQuantity.Text = "";
                }

                if (num < 0)
                {
                    MessageBox.Show("Quantity must have a positive value.", "Invalid quantity");
                    tbQuantity.Text = "";
                }

                return num;
            }
            set
            {
                tbQuantity.Text = value.ToString();
            }
        }

        /** Value in "Subtotal" text box in Currency string format. */
        public string SubTotalDisplay
        {
            get
            {
                return register.Sale.getSubTotal().ToString("C");
            }
            set
            {
                lblSubTotalVal.Text = value;
            }
        }

        /** Value in "Tax" text box in Currency string format. */
        public string TaxDisplay
        {
            get
            {
                return register.Sale.getTax().ToString("C");
            }
            set
            {
                lblTaxVal.Text = value;
            }
        }

        /** Value in "Total" text box in Currency string format. */
        public string TotalDisplay
        {
            get
            {
                return register.Sale.getTotal().ToString("C");
            }
            set
            {
                lblTotalVal.Text = value;
            }
        }

        public string DateDisplay
        {
            get { return register.Sale.SaleDate.ToString(); }
        }

        public string BalanceDisplay
        {
            get { return register.Sale.getBalance().ToString("C"); }
        }

        #endregion 

    }
}
