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
            this.lblEnterAmount = new System.Windows.Forms.Label();
            this.tbEnterAmount = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblBalanceNo = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cashBtn
            // 
            this.cashBtn.Location = new System.Drawing.Point(12, 68);
            this.cashBtn.Name = "cashBtn";
            this.cashBtn.Size = new System.Drawing.Size(72, 32);
            this.cashBtn.TabIndex = 0;
            this.cashBtn.Text = "Cash";
            this.cashBtn.UseVisualStyleBackColor = true;
            this.cashBtn.Click += new System.EventHandler(this.cashBtn_Click);
            // 
            // creditCardBtn
            // 
            this.creditCardBtn.Location = new System.Drawing.Point(168, 68);
            this.creditCardBtn.Name = "creditCardBtn";
            this.creditCardBtn.Size = new System.Drawing.Size(72, 32);
            this.creditCardBtn.TabIndex = 1;
            this.creditCardBtn.Text = "Credit card";
            this.creditCardBtn.UseVisualStyleBackColor = true;
            this.creditCardBtn.Click += new System.EventHandler(this.creditCardBtn_Click);
            // 
            // lblEnterAmount
            // 
            this.lblEnterAmount.AutoSize = true;
            this.lblEnterAmount.Location = new System.Drawing.Point(9, 13);
            this.lblEnterAmount.Name = "lblEnterAmount";
            this.lblEnterAmount.Size = new System.Drawing.Size(73, 13);
            this.lblEnterAmount.TabIndex = 2;
            this.lblEnterAmount.Text = "Enter amount:";
            // 
            // tbEnterAmount
            // 
            this.tbEnterAmount.Location = new System.Drawing.Point(92, 10);
            this.tbEnterAmount.Name = "tbEnterAmount";
            this.tbEnterAmount.Size = new System.Drawing.Size(148, 20);
            this.tbEnterAmount.TabIndex = 3;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(9, 41);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(49, 13);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Balance:";
            // 
            // lblBalanceNo
            // 
            this.lblBalanceNo.AutoSize = true;
            this.lblBalanceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceNo.Location = new System.Drawing.Point(89, 41);
            this.lblBalanceNo.Name = "lblBalanceNo";
            this.lblBalanceNo.Size = new System.Drawing.Size(0, 15);
            this.lblBalanceNo.TabIndex = 5;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(90, 68);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(72, 32);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // FormPaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 112);
            this.Controls.Add(this.lblBalanceNo);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.tbEnterAmount);
            this.Controls.Add(this.lblEnterAmount);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.creditCardBtn);
            this.Controls.Add(this.cashBtn);
            this.Name = "FormPaymentMethod";
            this.Text = "Payment Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cashBtn;
        private System.Windows.Forms.Button creditCardBtn;
        private System.Windows.Forms.Label lblEnterAmount;
        private System.Windows.Forms.TextBox tbEnterAmount;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblBalanceNo;
        private System.Windows.Forms.Button btnCheck;
    }
}