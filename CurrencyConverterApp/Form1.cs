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
    public partial class Form1 : Form
    {
        string currency;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString("https://api.exchangeratesapi.io/latest");
                dynamic data = JObject.Parse(json);

                if (currency == "PLN")
                {
                    labelResult.Text = data.rates.PLN;
                }

                if (currency == "EUR")
                {
                    labelResult.Text = data.rates.EUR;
                }

                if (currency == "USD")
                {
                    labelResult.Text = data.rates.USD;
                }

                if (currency == "CHF")
                {
                    labelResult.Text = data.rates.CHF;
                }

                if (currency == "GBP")
                {
                    labelResult.Text = data.rates.GBP;
                }
            }
        }

        private void comboBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            currency = comboBoxTo.Text;
        }
    }
}
