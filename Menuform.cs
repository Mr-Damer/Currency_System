using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using CurrencyRateUpdater;

namespace Currency
{
    public partial class Menuform : Form
    {
        public Menuform()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=Damer;Initial Catalog=Currency Exchange;Integrated Security=True;");
        private void button1_Click(object sender, EventArgs e)
        {
            CurrenciesListForm currenciesForm = new CurrenciesListForm();
            currenciesForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FindCurrencyForm FindCurrencyForm = new FindCurrencyForm();
            FindCurrencyForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormUpdateCurrencyRate UpdateCurrencyForm = new FormUpdateCurrencyRate();
            UpdateCurrencyForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CurrencyCalculatorForm CurrencyCalculatorForm = new CurrencyCalculatorForm();
            CurrencyCalculatorForm.Show();
        }
    }

    public partial class CurrenciesListForm : Form
    {
        private DataGridView dataGridViewCurrencies;

        public CurrenciesListForm()
        {
            InitializeDataGridView();
            this.Load += new EventHandler(CurrenciesListForm_Load);
        }

        private void InitializeDataGridView()
        {
            dataGridViewCurrencies = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true
            };
            this.Controls.Add(dataGridViewCurrencies);
        }

        private void CurrenciesListForm_Load(object sender, EventArgs e)
        {
            ShowCurrenciesList();
        }

        private void ShowCurrenciesList()
        {
            string connectionString = "Data Source=Damer;Initial Catalog=Currency Exchange;Integrated Security=True;";
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT Country, CurrencyCode, CurrencyName, Rate FROM Currencies", connection);
                da.Fill(dataTable);
            }

            dataGridViewCurrencies.DataSource = dataTable;
        }
    }

    public class Currency
    {
        public string Country { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public decimal Rate { get; set; }
    }
}
