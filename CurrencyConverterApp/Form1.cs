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
        decimal amount, result;

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
            date = dateTimePickerFrom.Text;
            amount = numericUpDownFrom.Value;

            apiUrl = "https://api.exchangeratesapi.io/" + date + "?base=" + currencyNameFrom;

            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(apiUrl);
                dynamic data = JObject.Parse(json);

                if (currencyNameTo == "PLN")
                {
                    result = amount * Math.Round(Convert.ToDecimal(data.rates.PLN), 2);
                }

                if (currencyNameTo == "EUR")
                {
                    result = amount * Math.Round(Convert.ToDecimal(data.rates.EUR), 2);
                }

                if (currencyNameTo == "USD")
                {
                    result = amount * Math.Round(Convert.ToDecimal(data.rates.USD), 2);
                }

                if (currencyNameTo == "CHF")
                {
                    result = amount * Math.Round(Convert.ToDecimal(data.rates.CHF), 2);
                }

                if (currencyNameTo == "GBP")
                {
                    result = amount * Math.Round(Convert.ToDecimal(data.rates.GBP), 2);
                }
            }

            labelResult.Text = numericUpDownFrom.Value + " " + currencyNameFrom + " = " + Convert.ToString(result) + " " + currencyNameTo;
            labelResult.Visible = true;

            addRecord(date, Convert.ToString(amount), currencyNameFrom, Convert.ToString(result), currencyNameTo, "rates.csv");
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

        public static void addRecord(string value1, string value2, string value3, string value4, string value5, string filepath)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(@filepath, true))
                {
                    if (new FileInfo(filepath).Length == 0)
                    {
                        file.WriteLine("Date" + "," + "Amount" + "," + "From" + "," + "Result" + "," + "To");
                    }

                    file.WriteLine(value1 + "," + value2 + "," + value3 + "," + value4 + "," + value5);
                }
            }
            catch (Exception e)
            {
                throw new ApplicationException("Error: ", e);
            }
        }
    }
}
