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
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(apiUrl);
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
            pictureBoxTo.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(comboBoxTo.Text);
        }

        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            apiUrl = "https://api.exchangeratesapi.io/latest?base=" + comboBoxFrom.Text;
            pictureBoxFrom.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(comboBoxFrom.Text);
        }
    }
}
