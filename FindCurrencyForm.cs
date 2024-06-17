using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Currency
{
    public partial class FindCurrencyForm : Form
    {
        public FindCurrencyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currencyCode = txtCurrencyCode.Text;
            Currency foundCurrency = Currency.FindByCode(currencyCode);
            ShowResults(foundCurrency);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string country = txtCountry.Text;
            Currency foundCurrency = Currency.FindByCountry(country);
            ShowResults(foundCurrency);
        }

        private void ShowResults(Currency foundCurrency)
        {
            if (!foundCurrency.IsEmpty)
            {
                // Use the properties of foundCurrency object
                var currencyData = new
                {
                    Country = foundCurrency.Country,
                    CurrencyCode = foundCurrency.CurrencyCode,
                    CurrencyName = foundCurrency.CurrencyName,
                    Rate = foundCurrency.Rate
                };

                MessageBox.Show($"Currency Found :-)\n\n" +
                                $"Country  : {currencyData.Country}\n" +
                                $"Code     : {currencyData.CurrencyCode}\n" +
                                $"Name     : {currencyData.CurrencyName}\n" +
                                $"Rate(1$) = : {currencyData.Rate}\n",
                                "Currency Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Currency Was not Found :-(", "Currency Details", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public class Currency
        {
            public string Country { get; set; }
            public string CurrencyCode { get; set; }
            public string CurrencyName { get; set; }
            public decimal Rate { get; set; }
            public bool IsEmpty { get; set; } = true;  // Default to true, assuming it's empty

            public static Currency FindByCode(string code)
            {
                using (var connection = new SqlConnection("Data Source=Damer;Initial Catalog=Currency Exchange;Integrated Security=True;"))
                {
                    string query = "SELECT Country AS CountryName, CurrencyCode AS Code, CurrencyName AS Name, Rate AS ExchangeRate FROM Currencies WHERE CurrencyCode = @CurrencyCode";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@CurrencyCode", code);
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Currency
                                {
                                    Country = reader["CountryName"].ToString(),
                                    CurrencyCode = reader["Code"].ToString(),
                                    CurrencyName = reader["Name"].ToString(),
                                    Rate = Convert.ToDecimal(reader["ExchangeRate"]),
                                    IsEmpty = false // Currency found
                                };
                            }
                        }
                    }
                }
                return new Currency(); // Return an empty currency if not found
            }

            public static Currency FindByCountry(string country)
            {
                using (var connection = new SqlConnection("Data Source=Damer;Initial Catalog=Currency Exchange;Integrated Security=True;"))
                {
                    string query = "SELECT Country AS CountryName, CurrencyCode AS Code, CurrencyName AS Name, Rate AS ExchangeRate FROM Currencies WHERE Country = @Country";
                    using (var command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Country", country);
                        connection.Open();
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Currency
                                {
                                    Country = reader["CountryName"].ToString(),
                                    CurrencyCode = reader["Code"].ToString(),
                                    CurrencyName = reader["Name"].ToString(),
                                    Rate = Convert.ToDecimal(reader["ExchangeRate"]),
                                    IsEmpty = false // Currency found
                                };
                            }
                        }
                    }
                }
                return new Currency(); // Return an empty currency if not found
            }
        }
    }
}
