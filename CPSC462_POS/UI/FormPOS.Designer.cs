namespace CPSC462_POS
{
    partial class FormPOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblItemNo = new System.Windows.Forms.Label();
            this.tbItemNo = new System.Windows.Forms.TextBox();
            this.dgItemLine = new System.Windows.Forms.DataGridView();
            this.ItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChangeQuantity = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnVoidItem = new System.Windows.Forms.Button();
            this.btnNewSale = new System.Windows.Forms.Button();
            this.lblSaleDate = new System.Windows.Forms.Label();
            this.lblBalanceDue = new System.Windows.Forms.Label();
            this.lblSubTotalVal = new System.Windows.Forms.Label();
            this.lblTaxVal = new System.Windows.Forms.Label();
            this.lblTotalVal = new System.Windows.Forms.Label();
            this.lblSaleDateVal = new System.Windows.Forms.Label();
            this.lblBalanceDueVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemLine)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemNo
            // 
            this.lblItemNo.AutoSize = true;
            this.lblItemNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemNo.Location = new System.Drawing.Point(4, 9);
            this.lblItemNo.Name = "lblItemNo";
            this.lblItemNo.Size = new System.Drawing.Size(50, 19);
            this.lblItemNo.TabIndex = 0;
            this.lblItemNo.Text = "Item #";
            // 
            // tbItemNo
            // 
            this.tbItemNo.Location = new System.Drawing.Point(8, 31);
            this.tbItemNo.Name = "tbItemNo";
            this.tbItemNo.Size = new System.Drawing.Size(369, 20);
            this.tbItemNo.TabIndex = 0;
            this.tbItemNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbItemNo_KeyPress);
            // 
            // dgItemLine
            // 
            this.dgItemLine.AllowUserToAddRows = false;
            this.dgItemLine.AllowUserToDeleteRows = false;
            this.dgItemLine.AllowUserToResizeColumns = false;
            this.dgItemLine.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItemLine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgItemLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItemLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNo,
            this.Description,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgItemLine.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItemLine.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgItemLine.Enabled = false;
            this.dgItemLine.Location = new System.Drawing.Point(8, 61);
            this.dgItemLine.Margin = new System.Windows.Forms.Padding(0);
            this.dgItemLine.MultiSelect = false;
            this.dgItemLine.Name = "dgItemLine";
            this.dgItemLine.RowHeadersVisible = false;
            this.dgItemLine.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgItemLine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgItemLine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgItemLine.ShowCellToolTips = false;
            this.dgItemLine.ShowEditingIcon = false;
            this.dgItemLine.Size = new System.Drawing.Size(369, 204);
            this.dgItemLine.TabIndex = 20;
            this.dgItemLine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItemLine_CellClick);
            // 
            // ItemNo
            // 
            this.ItemNo.HeaderText = "Item No";
            this.ItemNo.MinimumWidth = 80;
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemNo.Width = 80;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 120;
            this.Description.Name = "Description";
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Description.Width = 120;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 52;
            this.Quantity.Name = "Quantity";
            this.Quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Quantity.Width = 52;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 54;
            this.Price.Name = "Price";
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.Width = 54;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 60;
            this.Total.Name = "Total";
            this.Total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Total.Width = 60;
            // 
            // btnChangeQuantity
            // 
            this.btnChangeQuantity.Location = new System.Drawing.Point(385, 103);
            this.btnChangeQuantity.Name = "btnChangeQuantity";
            this.btnChangeQuantity.Size = new System.Drawing.Size(86, 36);
            this.btnChangeQuantity.TabIndex = 30;
            this.btnChangeQuantity.Text = "Change Quantity";
            this.btnChangeQuantity.UseVisualStyleBackColor = true;
            this.btnChangeQuantity.Click += new System.EventHandler(this.btnChangeQuantity_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(317, 277);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(60, 18);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Location = new System.Drawing.Point(387, 187);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(86, 36);
            this.btnMakePayment.TabIndex = 40;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(349, 295);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(28, 18);
            this.lblTax.TabIndex = 7;
            this.lblTax.Text = "Tax";
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.AutoSize = true;
            this.lblFinalTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalTotal.Location = new System.Drawing.Point(267, 315);
            this.lblFinalTotal.Name = "lblFinalTotal";
            this.lblFinalTotal.Size = new System.Drawing.Size(110, 23);
            this.lblFinalTotal.TabIndex = 8;
            this.lblFinalTotal.Text = "FINAL TOTAL";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(381, 9);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 19);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(385, 31);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(85, 20);
            this.tbQuantity.TabIndex = 10;
            this.tbQuantity.WordWrap = false;
            this.tbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantity_KeyPress);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(387, 229);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(86, 36);
            this.btnPrintReceipt.TabIndex = 81;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // btnVoidItem
            // 
            this.btnVoidItem.Location = new System.Drawing.Point(385, 145);
            this.btnVoidItem.Name = "btnVoidItem";
            this.btnVoidItem.Size = new System.Drawing.Size(86, 36);
            this.btnVoidItem.TabIndex = 82;
            this.btnVoidItem.Text = "Void Item";
            this.btnVoidItem.UseVisualStyleBackColor = true;
            this.btnVoidItem.Click += new System.EventHandler(this.btnItemVoid_Click);
            // 
            // btnNewSale
            // 
            this.btnNewSale.Location = new System.Drawing.Point(384, 61);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(86, 36);
            this.btnNewSale.TabIndex = 30;
            this.btnNewSale.Text = "Create New Sale";
            this.btnNewSale.UseVisualStyleBackColor = true;
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // lblSaleDate
            // 
            this.lblSaleDate.AutoSize = true;
            this.lblSaleDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleDate.Location = new System.Drawing.Point(5, 277);
            this.lblSaleDate.Name = "lblSaleDate";
            this.lblSaleDate.Size = new System.Drawing.Size(41, 18);
            this.lblSaleDate.TabIndex = 83;
            this.lblSaleDate.Text = "Date:";
            // 
            // lblBalanceDue
            // 
            this.lblBalanceDue.AutoSize = true;
            this.lblBalanceDue.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceDue.ForeColor = System.Drawing.Color.Red;
            this.lblBalanceDue.Location = new System.Drawing.Point(4, 297);
            this.lblBalanceDue.Name = "lblBalanceDue";
            this.lblBalanceDue.Size = new System.Drawing.Size(113, 23);
            this.lblBalanceDue.TabIndex = 8;
            this.lblBalanceDue.Text = "Balance Due:";
            // 
            // lblSubTotalVal
            // 
            this.lblSubTotalVal.AutoSize = true;
            this.lblSubTotalVal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotalVal.ForeColor = System.Drawing.Color.Green;
            this.lblSubTotalVal.Location = new System.Drawing.Point(383, 277);
            this.lblSubTotalVal.Name = "lblSubTotalVal";
            this.lblSubTotalVal.Size = new System.Drawing.Size(0, 18);
            this.lblSubTotalVal.TabIndex = 85;
            // 
            // lblTaxVal
            // 
            this.lblTaxVal.AutoSize = true;
            this.lblTaxVal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxVal.ForeColor = System.Drawing.Color.Green;
            this.lblTaxVal.Location = new System.Drawing.Point(383, 295);
            this.lblTaxVal.Name = "lblTaxVal";
            this.lblTaxVal.Size = new System.Drawing.Size(0, 18);
            this.lblTaxVal.TabIndex = 85;
            // 
            // lblTotalVal
            // 
            this.lblTotalVal.AutoSize = true;
            this.lblTotalVal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalVal.ForeColor = System.Drawing.Color.Green;
            this.lblTotalVal.Location = new System.Drawing.Point(383, 315);
            this.lblTotalVal.Name = "lblTotalVal";
            this.lblTotalVal.Size = new System.Drawing.Size(0, 23);
            this.lblTotalVal.TabIndex = 85;
            // 
            // lblSaleDateVal
            // 
            this.lblSaleDateVal.AutoSize = true;
            this.lblSaleDateVal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaleDateVal.Location = new System.Drawing.Point(52, 277);
            this.lblSaleDateVal.Name = "lblSaleDateVal";
            this.lblSaleDateVal.Size = new System.Drawing.Size(0, 18);
            this.lblSaleDateVal.TabIndex = 85;
            // 
            // lblBalanceDueVal
            // 
            this.lblBalanceDueVal.AutoSize = true;
            this.lblBalanceDueVal.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceDueVal.ForeColor = System.Drawing.Color.Red;
            this.lblBalanceDueVal.Location = new System.Drawing.Point(123, 295);
            this.lblBalanceDueVal.Name = "lblBalanceDueVal";
            this.lblBalanceDueVal.Size = new System.Drawing.Size(0, 26);
            this.lblBalanceDueVal.TabIndex = 85;
            // 
            // FormPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 341);
            this.Controls.Add(this.lblTotalVal);
            this.Controls.Add(this.lblBalanceDueVal);
            this.Controls.Add(this.lblSaleDateVal);
            this.Controls.Add(this.lblTaxVal);
            this.Controls.Add(this.lblSubTotalVal);
            this.Controls.Add(this.lblSaleDate);
            this.Controls.Add(this.btnVoidItem);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblBalanceDue);
            this.Controls.Add(this.lblFinalTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.btnMakePayment);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnNewSale);
            this.Controls.Add(this.btnChangeQuantity);
            this.Controls.Add(this.dgItemLine);
            this.Controls.Add(this.tbItemNo);
            this.Controls.Add(this.lblItemNo);
            this.Name = "FormPOS";
            this.Text = "CPSC462 POS";
            this.Activated += new System.EventHandler(this.FormPOS_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgItemLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblItemNo;
        private System.Windows.Forms.TextBox tbItemNo;
        private System.Windows.Forms.DataGridView dgItemLine;
        private System.Windows.Forms.Button btnChangeQuantity;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblFinalTotal;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnVoidItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnNewSale;
        private System.Windows.Forms.Label lblSaleDate;
        private System.Windows.Forms.Label lblBalanceDue;
        private System.Windows.Forms.Label lblSubTotalVal;
        private System.Windows.Forms.Label lblTaxVal;
        private System.Windows.Forms.Label lblTotalVal;
        private System.Windows.Forms.Label lblSaleDateVal;
        private System.Windows.Forms.Label lblBalanceDueVal;
    }
}

