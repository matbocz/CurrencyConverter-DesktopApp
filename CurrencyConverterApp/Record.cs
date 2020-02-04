using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverterApp
{
    public class Record
    {
        public static void addRecord(string val1, string val2, string val3, string val4, string val5, string filepath)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(@filepath, true))
                {
                    if (new FileInfo(filepath).Length == 0)
                    {
                        file.WriteLine("Date" + ";" + "Amount" + ";" + "From" + ";" + "Rate" + ";" + "To");
                    }

                    file.WriteLine(val1 + ";" + val2 + ";" + val3 + ";" + val4 + ";" + val5);
                }
            }
            catch (Exception e)
            {
                throw new ApplicationException("Error: ", e);
            }
        }
    }
}
