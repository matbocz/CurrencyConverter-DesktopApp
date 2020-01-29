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
        string currencyNameFrom, currencyNameTo;
        string apiUrl;

        public Form1()
        {
            InitializeComponent();

            comboBoxFrom.SelectedIndex = 1;
            comboBoxTo.SelectedIndex = 0;

            dateTimePickerFrom.Value = DateTime.Today;
            dateTimePickerFrom.MaxDate = DateTime.Today;
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            apiUrl = "https://api.exchangeratesapi.io/" + dateTimePickerFrom.Text + "?base=" + currencyNameFrom;

            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(apiUrl);
                dynamic data = JObject.Parse(json);
                decimal result = 0;

                if (currencyNameTo == "PLN")
                {
                    result = numericUpDownFrom.Value * Math.Round(Convert.ToDecimal(data.rates.PLN), 2);
                }

                if (currencyNameTo == "EUR")
                {
                    result = numericUpDownFrom.Value * Math.Round(Convert.ToDecimal(data.rates.EUR), 2);
                }

                if (currencyNameTo == "USD")
                {
                    result = numericUpDownFrom.Value * Math.Round(Convert.ToDecimal(data.rates.USD), 2);
                }

                if (currencyNameTo == "CHF")
                {
                    result = numericUpDownFrom.Value * Math.Round(Convert.ToDecimal(data.rates.CHF), 2);
                }

                if (currencyNameTo == "GBP")
                {
                    result = numericUpDownFrom.Value * Math.Round(Convert.ToDecimal(data.rates.GBP), 2);
                }

                labelResult.Visible = true;
                labelResult.Text = numericUpDownFrom.Value + " " + currencyNameFrom +" = "+ Convert.ToString(result) + " " + currencyNameTo;
            }
        }

        private void comboBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            currencyNameTo = comboBoxTo.Text;
            pictureBoxTo.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(comboBoxTo.Text);
        }

        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            currencyNameFrom = comboBoxFrom.Text;
            pictureBoxFrom.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(comboBoxFrom.Text);
        }
    }
}
