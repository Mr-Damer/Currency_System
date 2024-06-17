namespace Currency
{
    partial class CurrencyCalculatorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCurrencyFrom;
        private System.Windows.Forms.TextBox txtCurrencyFrom;
        private System.Windows.Forms.Label lblCurrencyTo;
        private System.Windows.Forms.TextBox txtCurrencyTo;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnCalculate;



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
            this.lblCurrencyFrom = new System.Windows.Forms.Label();
            this.txtCurrencyFrom = new System.Windows.Forms.TextBox();
            this.lblCurrencyTo = new System.Windows.Forms.Label();
            this.txtCurrencyTo = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblCurrencyFrom
            this.lblCurrencyFrom.AutoSize = true;
            this.lblCurrencyFrom.Location = new System.Drawing.Point(13, 13);
            this.lblCurrencyFrom.Name = "lblCurrencyFrom";
            this.lblCurrencyFrom.Size = new System.Drawing.Size(76, 13);
            this.lblCurrencyFrom.TabIndex = 0;
            this.lblCurrencyFrom.Text = "Currency From";

            // txtCurrencyFrom
            this.txtCurrencyFrom.Location = new System.Drawing.Point(95, 10);
            this.txtCurrencyFrom.Name = "txtCurrencyFrom";
            this.txtCurrencyFrom.Size = new System.Drawing.Size(100, 20);
            this.txtCurrencyFrom.TabIndex = 1;

            // lblCurrencyTo
            this.lblCurrencyTo.AutoSize = true;
            this.lblCurrencyTo.Location = new System.Drawing.Point(13, 39);
            this.lblCurrencyTo.Name = "lblCurrencyTo";
            this.lblCurrencyTo.Size = new System.Drawing.Size(64, 13);
            this.lblCurrencyTo.TabIndex = 2;
            this.lblCurrencyTo.Text = "Currency To";

            // txtCurrencyTo
            this.txtCurrencyTo.Location = new System.Drawing.Point(95, 36);
            this.txtCurrencyTo.Name = "txtCurrencyTo";
            this.txtCurrencyTo.Size = new System.Drawing.Size(100, 20);
            this.txtCurrencyTo.TabIndex = 3;

            // lblAmount
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(13, 65);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "Amount";

            // txtAmount
            this.txtAmount.Location = new System.Drawing.Point(95, 62);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 20);
            this.txtAmount.TabIndex = 5;

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(16, 88);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(179, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // CurrencyCalculatorForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtCurrencyTo);
            this.Controls.Add(this.lblCurrencyTo);
            this.Controls.Add(this.txtCurrencyFrom);
            this.Controls.Add(this.lblCurrencyFrom);
            this.Name = "CurrencyCalculatorForm";
            this.Text = "Currency Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }

    #endregion

    //private System.Windows.Forms.Button btnCalculate;
    //private System.Windows.Forms.Label label1;
    //private System.Windows.Forms.Label label2;
    //private System.Windows.Forms.Label label3;
    //private System.Windows.Forms.TextBox textBox1;
    //private System.Windows.Forms.TextBox textBox2;
    //private System.Windows.Forms.TextBox textBox3;
}
