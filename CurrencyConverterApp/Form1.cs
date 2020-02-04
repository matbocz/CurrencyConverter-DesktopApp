using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverterApp
{
    public partial class Form1 : Form
    {
        string currencyNameFrom, currencyNameTo, date, apiUrl;
        string filePath = "rates.csv";
        decimal amount, rate;

        public Form1()
        {
            InitializeComponent();

            comboBoxFrom.SelectedIndex = 1;
            comboBoxTo.SelectedIndex = 0;

            dateTimePickerFrom.Value = DateTime.Today;
            dateTimePickerFrom.MaxDate = DateTime.Today;
        }

        // Button - show saved rates
        private void buttonShowRates_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("You do not have saved exchange rates!");
            }
            else
            {
                FormRates f = new FormRates(filePath);
                f.Show();
            }
        }

        // Button - delete saved rates
        private void buttonDeleteRates_Click(object sender, EventArgs e)
        {
            File.Delete(filePath);

            MessageBox.Show("You have removed saved exchange rates.");
        }

        // Button - show exchange rates table
        private void buttonTable_Click(object sender, EventArgs e)
        {
            FormTable f = new FormTable();
            f.Show();
        }

        // Button - convert
        private void buttonConvert_Click(object sender, EventArgs e)
        {
            date = dateTimePickerFrom.Text;
            amount = numericUpDownFrom.Value;

            apiUrl = "https://api.exchangeratesapi.io/" + date + "?base=" + currencyNameFrom;

            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(apiUrl);
                dynamic data = JObject.Parse(json);

                if (currencyNameTo == "PLN")
                {
                    rate = amount * Math.Round(Convert.ToDecimal(data.rates.PLN), 2);
                }

                if (currencyNameTo == "EUR")
                {
                    rate = amount * Math.Round(Convert.ToDecimal(data.rates.EUR), 2);
                }

                if (currencyNameTo == "USD")
                {
                    rate = amount * Math.Round(Convert.ToDecimal(data.rates.USD), 2);
                }

                if (currencyNameTo == "CHF")
                {
                    rate = amount * Math.Round(Convert.ToDecimal(data.rates.CHF), 2);
                }

                if (currencyNameTo == "GBP")
                {
                    rate = amount * Math.Round(Convert.ToDecimal(data.rates.GBP), 2);
                }
            }

            labelResult.Text = numericUpDownFrom.Value + " " + currencyNameFrom + " = " + Convert.ToString(rate) + " " + currencyNameTo;
            labelResult.Visible = true;

            Record.addRecord(date, Convert.ToString(amount), currencyNameFrom, Convert.ToString(rate), currencyNameTo, filePath);
        }

        // comboBox - currency to
        private void comboBoxTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            currencyNameTo = comboBoxTo.Text;
            pictureBoxTo.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(comboBoxTo.Text);
        }

        // comboBox - currency from
        private void comboBoxFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            currencyNameFrom = comboBoxFrom.Text;
            pictureBoxFrom.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject(comboBoxFrom.Text);
        }
    }
}
