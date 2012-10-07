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

        public FormPOS()
        {
            InitializeComponent();
        }

        private void tbItemNo_Leave(object sender, EventArgs e)
        {
            // will replace all below with database query code
            tbQuantity.Text = (tbQuantity.Text == "" ? "1" : tbQuantity.Text);
            if (tbItemNo.Text == "1234")
            {
                dgItemLine.Rows.Add(tbItemNo.Text, "Chinese iPad", tbQuantity.Text, 1.00, "1.00");
                tbItemNo.Clear();
            }
        }

        private void tbItemNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return || e.KeyChar == (char)Keys.Enter)
            {
                tbItemNo_Leave(sender, e);
            }
        }




    }
}
