using System;
using System.Data.SqlClient;

public class Curr
{
    public string Country { get; set; }
    public string CurrencyCode { get; set; }
    public string CurrencyName { get; set; }
    public float Rate { get; set; }

    public static bool IsCurrencyExist(string currencyCode)
    {
        using (SqlConnection conn = new SqlConnection(@"Data Source=Damer;Initial Catalog=Currency Exchange;Integrated Security=True;"))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Currencies WHERE CurrencyCode = @CurrencyCode", conn))
            {
                cmd.Parameters.AddWithValue("@CurrencyCode", currencyCode);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }

    public static Curr FindByCode(string currencyCode)
    {
        using (SqlConnection conn = new SqlConnection(@"Data Source=Damer;Initial Catalog=Currency Exchange;Integrated Security=True;"))
        {
            conn.Open();
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Currencies WHERE CurrencyCode = @CurrencyCode", conn))
            {
                cmd.Parameters.AddWithValue("@CurrencyCode", currencyCode);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Curr
                        {
                            Country = reader["Country"].ToString(),
                            CurrencyCode = reader["CurrencyCode"].ToString(),
                            CurrencyName = reader["CurrencyName"].ToString(),
                            Rate = float.Parse(reader["Rate"].ToString())
                        };
                    }
                }
            }
        }
        return null;
    }

    public float ConvertToUSD(float amount)
    {
        return amount / Rate;
    }

    public float ConvertToOtherCurrency(float amount, Curr targetCurrency)
    {
        float amountInUSD = ConvertToUSD(amount);
        return amountInUSD * targetCurrency.Rate;
    }
}
