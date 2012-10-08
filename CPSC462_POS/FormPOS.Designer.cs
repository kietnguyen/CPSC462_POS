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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnVoidSale = new System.Windows.Forms.Button();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.tbTax = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnVoidItem = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgItemLine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgItemLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItemLine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNo,
            this.Description,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgItemLine.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgItemLine.DefaultCellStyle = dataGridViewCellStyle6;
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
            this.btnChangeQuantity.Location = new System.Drawing.Point(385, 61);
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
            this.lblSubtotal.Location = new System.Drawing.Point(319, 275);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(60, 18);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Location = new System.Drawing.Point(385, 187);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(86, 36);
            this.btnMakePayment.TabIndex = 40;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            // 
            // btnVoidSale
            // 
            this.btnVoidSale.Location = new System.Drawing.Point(385, 145);
            this.btnVoidSale.Name = "btnVoidSale";
            this.btnVoidSale.Size = new System.Drawing.Size(86, 36);
            this.btnVoidSale.TabIndex = 50;
            this.btnVoidSale.Text = "Void Sale";
            this.btnVoidSale.UseVisualStyleBackColor = true;
            this.btnVoidSale.Click += new System.EventHandler(this.btnVoidSale_Click);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(351, 293);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(28, 18);
            this.lblTax.TabIndex = 7;
            this.lblTax.Text = "Tax";
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.AutoSize = true;
            this.lblFinalTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalTotal.Location = new System.Drawing.Point(269, 313);
            this.lblFinalTotal.Name = "lblFinalTotal";
            this.lblFinalTotal.Size = new System.Drawing.Size(110, 23);
            this.lblFinalTotal.TabIndex = 8;
            this.lblFinalTotal.Text = "FINAL TOTAL";
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Location = new System.Drawing.Point(385, 273);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.Size = new System.Drawing.Size(86, 20);
            this.tbSubtotal.TabIndex = 60;
            // 
            // tbTax
            // 
            this.tbTax.Enabled = false;
            this.tbTax.Location = new System.Drawing.Point(385, 291);
            this.tbTax.Name = "tbTax";
            this.tbTax.Size = new System.Drawing.Size(86, 20);
            this.tbTax.TabIndex = 70;
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(385, 313);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(86, 20);
            this.tbTotal.TabIndex = 80;
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
            this.tbQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbQuantity_KeyPress);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(385, 229);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(86, 36);
            this.btnPrintReceipt.TabIndex = 81;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            // 
            // btnVoidItem
            // 
            this.btnVoidItem.Location = new System.Drawing.Point(385, 103);
            this.btnVoidItem.Name = "btnVoidItem";
            this.btnVoidItem.Size = new System.Drawing.Size(86, 36);
            this.btnVoidItem.TabIndex = 82;
            this.btnVoidItem.Text = "Void Item";
            this.btnVoidItem.UseVisualStyleBackColor = true;
            this.btnVoidItem.Click += new System.EventHandler(this.btnItemVoid_Click);
            // 
            // FormPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 342);
            this.Controls.Add(this.btnVoidItem);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbTax);
            this.Controls.Add(this.tbSubtotal);
            this.Controls.Add(this.lblFinalTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.btnVoidSale);
            this.Controls.Add(this.btnMakePayment);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnChangeQuantity);
            this.Controls.Add(this.dgItemLine);
            this.Controls.Add(this.tbItemNo);
            this.Controls.Add(this.lblItemNo);
            this.Name = "FormPOS";
            this.Text = "CPSC462 POS";
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
        private System.Windows.Forms.Button btnVoidSale;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblFinalTotal;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.TextBox tbTax;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnVoidItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}

