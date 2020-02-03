using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverterApp
{
    public partial class FormRates : Form
    {
        DataTable myDataTable = new DataTable();
        string filePath;

        public FormRates(string path)
        {
            InitializeComponent();

            filePath = path;
        }

        private void FormRates_Load(object sender, EventArgs e)
        {
            string[] rawText = File.ReadAllLines(filePath);
            string[] dataCol = null;

            int x = 0;
            foreach (string textLine in rawText)
            {
                dataCol = textLine.Split(';');

                if (x == 0)
                {
                    for (int i = 0; i <= dataCol.Count() - 1; i++)
                    {
                        myDataTable.Columns.Add(dataCol[i]);
                    }

                    x = 1;
                }
                else
                {
                    myDataTable.Rows.Add(dataCol);
                }
            }

            myDataGridView.DataSource = myDataTable;
        }
    }
}
