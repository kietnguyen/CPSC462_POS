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
            this.lblItemNo = new System.Windows.Forms.Label();
            this.tbItemNo = new System.Windows.Forms.TextBox();
            this.dgItemLine = new System.Windows.Forms.DataGridView();
            this.btnChangeQuantity = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.btnVoidSale = new System.Windows.Forms.Button();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.tbTax = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
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
            this.tbItemNo.Size = new System.Drawing.Size(366, 20);
            this.tbItemNo.TabIndex = 0;
            // 
            // dgItemLine
            // 
            this.dgItemLine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItemLine.Location = new System.Drawing.Point(8, 61);
            this.dgItemLine.Name = "dgItemLine";
            this.dgItemLine.Size = new System.Drawing.Size(366, 201);
            this.dgItemLine.TabIndex = 20;
            this.dgItemLine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnChangeQuantity
            // 
            this.btnChangeQuantity.Location = new System.Drawing.Point(381, 61);
            this.btnChangeQuantity.Name = "btnChangeQuantity";
            this.btnChangeQuantity.Size = new System.Drawing.Size(86, 36);
            this.btnChangeQuantity.TabIndex = 30;
            this.btnChangeQuantity.Text = "Change Quantity";
            this.btnChangeQuantity.UseVisualStyleBackColor = true;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(317, 272);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(60, 18);
            this.lblSubtotal.TabIndex = 4;
            this.lblSubtotal.Text = "Subtotal";
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.Location = new System.Drawing.Point(381, 103);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(86, 36);
            this.btnMakePayment.TabIndex = 40;
            this.btnMakePayment.Text = "Make Payment";
            this.btnMakePayment.UseVisualStyleBackColor = true;
            // 
            // btnVoidSale
            // 
            this.btnVoidSale.Location = new System.Drawing.Point(381, 145);
            this.btnVoidSale.Name = "btnVoidSale";
            this.btnVoidSale.Size = new System.Drawing.Size(86, 36);
            this.btnVoidSale.TabIndex = 50;
            this.btnVoidSale.Text = "Void Sale";
            this.btnVoidSale.UseVisualStyleBackColor = true;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(349, 290);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(28, 18);
            this.lblTax.TabIndex = 7;
            this.lblTax.Text = "Tax";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(318, 308);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(59, 23);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = "TOTAL";
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Enabled = false;
            this.tbSubtotal.Location = new System.Drawing.Point(380, 268);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.Size = new System.Drawing.Size(86, 20);
            this.tbSubtotal.TabIndex = 60;
            // 
            // tbTax
            // 
            this.tbTax.Enabled = false;
            this.tbTax.Location = new System.Drawing.Point(380, 286);
            this.tbTax.Name = "tbTax";
            this.tbTax.Size = new System.Drawing.Size(86, 20);
            this.tbTax.TabIndex = 70;
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(380, 309);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(86, 20);
            this.tbTotal.TabIndex = 80;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(377, 8);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(65, 19);
            this.lblQuantity.TabIndex = 12;
            this.lblQuantity.Text = "Quantity";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(380, 30);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(85, 20);
            this.tbQuantity.TabIndex = 10;
            // 
            // FormPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 339);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbTax);
            this.Controls.Add(this.tbSubtotal);
            this.Controls.Add(this.lblTotal);
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
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.TextBox tbTax;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox tbQuantity;
    }
}

