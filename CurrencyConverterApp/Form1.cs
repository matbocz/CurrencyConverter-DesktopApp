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

        private void buttonDeleteRates_Click(object sender, EventArgs e)
        {
            File.Delete(filePath);
            MessageBox.Show("You have removed saved exchange rates.");
        }

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

            addRecord(date, Convert.ToString(amount), currencyNameFrom, Convert.ToString(rate), currencyNameTo, filePath);
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

        public static void addRecord(string val1, string val2, string val3, string val4, string val5, string filepath)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(@filepath, true))
                {
                    if (new FileInfo(filepath).Length == 0)
                    {
                        file.WriteLine("Date" + "," + "Amount" + "," + "From" + "," + "Rate" + "," + "To");
                    }

                    file.WriteLine(val1 + "," + val2 + "," + val3 + "," + val4 + "," + val5);
                }
            }
            catch (Exception e)
            {
                throw new ApplicationException("Error: ", e);
            }
        }
    }
}
