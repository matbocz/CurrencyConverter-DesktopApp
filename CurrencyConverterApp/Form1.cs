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
        string apiUrl;

        public Form1()
        {
            InitializeComponent();
            comboBoxFrom.SelectedIndex = 1;
            comboBoxTo.SelectedIndex = 0;
            numericUpDownFrom.Value = 1;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(apiUrl);
                dynamic data = JObject.Parse(json);
                decimal d = 0;

                if (currency == "PLN")
                {
                    d = numericUpDownFrom.Value * Math.Round(Convert.ToDecimal(data.rates.PLN), 2);
                }

                if (currency == "EUR")
                {
                    d = numericUpDownFrom.Value * Math.Round(Convert.ToDecimal(data.rates.EUR), 2);
                }

                if (currency == "USD")
                {
                    d = numericUpDownFrom.Value * Math.Round(Convert.ToDecimal(data.rates.USD), 2);
                }

                if (currency == "CHF")
                {
                    d = numericUpDownFrom.Value * Math.Round(Convert.ToDecimal(data.rates.CHF), 2);
                }

                if (currency == "GBP")
                {
                    d = numericUpDownFrom.Value * Math.Round(Convert.ToDecimal(data.rates.GBP), 2);
                }

                labelResult.Text = Convert.ToString(d);
            }
        }

        private void comboBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            currency = comboBoxTo.Text;
            pictureBoxTo.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(comboBoxTo.Text);
        }

        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            apiUrl = "https://api.exchangeratesapi.io/latest?base=" + comboBoxFrom.Text;
            pictureBoxFrom.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(comboBoxFrom.Text);
        }
    }
}
