using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverterApp
{
    public partial class FormTable : Form
    {
        string apiUrl;

        public FormTable()
        {
            InitializeComponent();
        }

        private void FormTable_Load(object sender, EventArgs e)
        {
            apiUrl = "https://api.exchangeratesapi.io/latest?base=PLN";
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(apiUrl);
                dynamic data = JObject.Parse(json);

                labelPLNPLN.Text = "1.00";
                labelPLNEUR.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.EUR), 2));
                labelPLNUSD.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.USD), 2));
                labelPLNCHF.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.CHF), 2));
                labelPLNGBP.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.GBP), 2));
            }

            apiUrl = "https://api.exchangeratesapi.io/latest?base=EUR";
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(apiUrl);
                dynamic data = JObject.Parse(json);

                labelEURPLN.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.PLN), 2));
                labelEUREUR.Text = "1.00";
                labelEURUSD.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.USD), 2));
                labelEURCHF.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.CHF), 2));
                labelEURGBP.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.GBP), 2));
            }

            apiUrl = "https://api.exchangeratesapi.io/latest?base=USD";
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(apiUrl);
                dynamic data = JObject.Parse(json);

                labelUSDPLN.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.PLN), 2));
                labelUSDEUR.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.EUR), 2));
                labelUSDUSD.Text = "1.00";
                labelUSDCHF.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.CHF), 2));
                labelUSDGBP.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.GBP), 2));
            }

            apiUrl = "https://api.exchangeratesapi.io/latest?base=CHF";
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(apiUrl);
                dynamic data = JObject.Parse(json);

                labelCHFPLN.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.PLN), 2));
                labelCHFEUR.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.EUR), 2));
                labelCHFUSD.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.USD), 2));
                labelCHFCHF.Text = "1.00";
                labelCHFGBP.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.GBP), 2));
            }

            apiUrl = "https://api.exchangeratesapi.io/latest?base=GBP";
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(apiUrl);
                dynamic data = JObject.Parse(json);

                labelGBPPLN.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.PLN), 2));
                labelGBPEUR.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.EUR), 2));
                labelGBPUSD.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.USD), 2));
                labelGBPCHF.Text = Convert.ToString(Math.Round(Convert.ToDecimal(data.rates.CHF), 2));
                labelGBPGBP.Text = "1.00";

                labelDate.Text += data.date;
            }
        }
    }
}
