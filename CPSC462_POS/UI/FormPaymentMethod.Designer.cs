namespace CPSC462_POS.UI
{
    partial class FormPaymentMethod
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
            this.cashBtn = new System.Windows.Forms.Button();
            this.creditCardBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cashBtn
            // 
            this.cashBtn.Location = new System.Drawing.Point(12, 12);
            this.cashBtn.Name = "cashBtn";
            this.cashBtn.Size = new System.Drawing.Size(100, 32);
            this.cashBtn.TabIndex = 0;
            this.cashBtn.Text = "Cash";
            this.cashBtn.UseVisualStyleBackColor = true;
            this.cashBtn.Click += new System.EventHandler(this.cashBtn_Click);
            // 
            // creditCardBtn
            // 
            this.creditCardBtn.Location = new System.Drawing.Point(126, 12);
            this.creditCardBtn.Name = "creditCardBtn";
            this.creditCardBtn.Size = new System.Drawing.Size(100, 32);
            this.creditCardBtn.TabIndex = 1;
            this.creditCardBtn.Text = "Credit card";
            this.creditCardBtn.UseVisualStyleBackColor = true;
            this.creditCardBtn.Click += new System.EventHandler(this.creditCardBtn_Click);
            // 
            // FormPaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 53);
            this.Controls.Add(this.creditCardBtn);
            this.Controls.Add(this.cashBtn);
            this.Name = "FormPaymentMethod";
            this.Text = "Payment Method";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cashBtn;
        private System.Windows.Forms.Button creditCardBtn;
    }
}