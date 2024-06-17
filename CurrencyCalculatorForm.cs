using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency
{
    public partial class CurrencyCalculatorForm : Form
    {
        public CurrencyCalculatorForm()
        {
            InitializeComponent();
        }

        private void CurrencyCalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string currencyFromCode = InputValidate.ReadString(txtCurrencyFrom.Text);
                string currencyToCode = InputValidate.ReadString(txtCurrencyTo.Text);
                float amount = InputValidate.ReadFloatNumber(txtAmount.Text);

                if (!Curr.IsCurrencyExist(currencyFromCode))
                {
                    MessageBox.Show("Currency From not found. Please enter a valid code.");
                    return;
                }

                if (!Curr.IsCurrencyExist(currencyToCode))
                {
                    MessageBox.Show("Currency To not found. Please enter a valid code.");
                    return;
                }

                Curr currencyFrom = Curr.FindByCode(currencyFromCode);
                Curr currencyTo = Curr.FindByCode(currencyToCode);

                PrintCalculationsResults(amount, currencyFrom, currencyTo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void PrintCalculationsResults(float amount, Curr currencyFrom, Curr currencyTo)
        {
            float amountInUSD = currencyFrom.ConvertToUSD(amount);
            MessageBox.Show($"{amount} {currencyFrom.CurrencyCode} = {amountInUSD} USD");

            if (currencyTo.CurrencyCode != "USD")
            {
                float amountInTargetCurrency = currencyFrom.ConvertToOtherCurrency(amount, currencyTo);
                MessageBox.Show($"{amount} {currencyFrom.CurrencyCode} = {amountInTargetCurrency} {currencyTo.CurrencyCode}");
            }
        }
    }
}
