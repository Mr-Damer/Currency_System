namespace Currency
{
    partial class currenciesForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewCurrencies;

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
            this.dataGridViewCurrencies = new System.Windows.Forms.DataGridView();
            this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrencyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrencies)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCurrencies
            // 
            this.dataGridViewCurrencies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCurrencies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Country,
            this.CurrencyCode,
            this.CurrencyName,
            this.Rate});
            this.dataGridViewCurrencies.Location = new System.Drawing.Point(16, 15);
            this.dataGridViewCurrencies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewCurrencies.Name = "dataGridViewCurrencies";
            this.dataGridViewCurrencies.RowHeadersWidth = 51;
            this.dataGridViewCurrencies.Size = new System.Drawing.Size(1013, 492);
            this.dataGridViewCurrencies.TabIndex = 0;
            // 
            // Country
            // 
            this.Country.HeaderText = "Country";
            this.Country.MinimumWidth = 6;
            this.Country.Name = "Country";
            this.Country.Width = 125;
            // 
            // CurrencyCode
            // 
            this.CurrencyCode.HeaderText = "CurrencyCode";
            this.CurrencyCode.MinimumWidth = 6;
            this.CurrencyCode.Name = "CurrencyCode";
            this.CurrencyCode.Width = 125;
            // 
            // CurrencyName
            // 
            this.CurrencyName.HeaderText = "CurrencyName";
            this.CurrencyName.MinimumWidth = 6;
            this.CurrencyName.Name = "CurrencyName";
            this.CurrencyName.Width = 125;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.MinimumWidth = 6;
            this.Rate.Name = "Rate";
            this.Rate.Width = 125;
            // 
            // currenciesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
            this.Controls.Add(this.dataGridViewCurrencies);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "currenciesForm";
            this.Text = "Currencies List";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCurrencies)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridViewTextBoxColumn Country;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrencyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
    }
}
