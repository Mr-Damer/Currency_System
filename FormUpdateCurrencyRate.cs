using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CurrencyRateUpdater
{
    public partial class FormUpdateCurrencyRate : Form
    {
        private string connectionString = "Data Source=Damer;Initial Catalog=Currency Exchange;Integrated Security=True;"; // Set your connection string here

        public FormUpdateCurrencyRate()
        {
            InitializeComponent();
        }

        private void btnFetchCurrency_Click(object sender, EventArgs e)
        {
            string currencyCode = txtCurrencyCode.Text;

            if (string.IsNullOrEmpty(currencyCode))
            {
                MessageBox.Show("Please enter a currency code.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(@"Data Source=Damer;Initial Catalog=Currency Exchange;Integrated Security=True;"))
            {
                string query = "SELECT Country, CurrencyCode, CurrencyName, Rate FROM Currencies WHERE CurrencyCode = @CurrencyCode";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CurrencyCode", currencyCode);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string country = reader["Country"].ToString();
                        string currencyName = reader["CurrencyName"].ToString();
                        float rate = float.Parse(reader["Rate"].ToString());

                        lblCurrencyDetails.Text = $"Country: {country}\nCode: {currencyCode}\nName: {currencyName}\nRate(1$): {rate}";
                    }
                    else
                    {
                        MessageBox.Show("Currency not found.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnUpdateRate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewRate.Text) || !float.TryParse(txtNewRate.Text, out float newRate))
            {
                MessageBox.Show("Please enter a valid rate.");
                return;
            }

            string currencyCode = txtCurrencyCode.Text;

            using (SqlConnection connection = new SqlConnection(@"Data Source=Damer;Initial Catalog=Currency Exchange;Integrated Security=True;"))
            {
                string updateQuery = "UPDATE Currencies SET Rate = @Rate WHERE CurrencyCode = @CurrencyCode";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@Rate", newRate);
                updateCommand.Parameters.AddWithValue("@CurrencyCode", currencyCode);

                try
                {
                    connection.Open();
                    int rowsAffected = updateCommand.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Currency rate updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Currency code not found or rate not updated.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void txtCurrencyCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNewRate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
