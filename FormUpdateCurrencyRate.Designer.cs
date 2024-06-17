namespace CurrencyRateUpdater
{
    partial class FormUpdateCurrencyRate
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCurrencyDetails;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtCurrencyCode;
        private System.Windows.Forms.TextBox txtNewRate;
        private System.Windows.Forms.Button btnFetchCurrency;
        private System.Windows.Forms.Button btnUpdateRate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCurrencyCode = new System.Windows.Forms.TextBox();
            this.btnFetchCurrency = new System.Windows.Forms.Button();
            this.lblCurrencyDetails = new System.Windows.Forms.Label();
            this.txtNewRate = new System.Windows.Forms.TextBox();
            this.btnUpdateRate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCurrencyCode
            // 
            this.txtCurrencyCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrencyCode.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCurrencyCode.Location = new System.Drawing.Point(13, 13);
            this.txtCurrencyCode.Name = "txtCurrencyCode";
            this.txtCurrencyCode.Size = new System.Drawing.Size(259, 24);
            this.txtCurrencyCode.TabIndex = 0;
            this.txtCurrencyCode.TextChanged += new System.EventHandler(this.txtCurrencyCode_TextChanged);
            // 
            // btnFetchCurrency
            // 
            this.btnFetchCurrency.Location = new System.Drawing.Point(13, 40);
            this.btnFetchCurrency.Name = "btnFetchCurrency";
            this.btnFetchCurrency.Size = new System.Drawing.Size(259, 23);
            this.btnFetchCurrency.TabIndex = 1;
            this.btnFetchCurrency.Text = "Fetch Currency";
            this.btnFetchCurrency.UseVisualStyleBackColor = true;
            this.btnFetchCurrency.Click += new System.EventHandler(this.btnFetchCurrency_Click);
            // 
            // lblCurrencyDetails
            // 
            this.lblCurrencyDetails.AutoSize = true;
            this.lblCurrencyDetails.Location = new System.Drawing.Point(13, 70);
            this.lblCurrencyDetails.Name = "lblCurrencyDetails";
            this.lblCurrencyDetails.Size = new System.Drawing.Size(0, 16);
            this.lblCurrencyDetails.TabIndex = 2;
            // 
            // txtNewRate
            // 
            this.txtNewRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewRate.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNewRate.Location = new System.Drawing.Point(13, 150);
            this.txtNewRate.Name = "txtNewRate";
            this.txtNewRate.Size = new System.Drawing.Size(259, 24);
            this.txtNewRate.TabIndex = 3;
            this.txtNewRate.TextChanged += new System.EventHandler(this.txtNewRate_TextChanged);
            // 
            // btnUpdateRate
            // 
            this.btnUpdateRate.Location = new System.Drawing.Point(13, 177);
            this.btnUpdateRate.Name = "btnUpdateRate";
            this.btnUpdateRate.Size = new System.Drawing.Size(259, 23);
            this.btnUpdateRate.TabIndex = 4;
            this.btnUpdateRate.Text = "Update Rate";
            this.btnUpdateRate.UseVisualStyleBackColor = true;
            this.btnUpdateRate.Click += new System.EventHandler(this.btnUpdateRate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(13, 210);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 5;
            // 
            // FormUpdateCurrencyRate
            // 
            this.ClientSize = new System.Drawing.Size(384, 253);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnUpdateRate);
            this.Controls.Add(this.txtNewRate);
            this.Controls.Add(this.lblCurrencyDetails);
            this.Controls.Add(this.btnFetchCurrency);
            this.Controls.Add(this.txtCurrencyCode);
            this.Name = "FormUpdateCurrencyRate";
            this.Text = "Update Currency Rate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
