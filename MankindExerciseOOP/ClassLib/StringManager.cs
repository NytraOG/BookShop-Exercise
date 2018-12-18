using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class StringManager
    {
        private const char Separator = ' ';
        //private string incomingString;

        //public StringManager(string incomingString)
        //{
        //    IncomingString = incomingString;
        //}

        //public string IncomingString
        //{
        //    set => incomingString = value;
        //}

        public List<object> SplitString(string incomingString)
        {
            var listIn = incomingString.Split(Separator).ToList();
            var listOut = new List<object>();

            foreach (var item in listIn)
            {
                bool isDecimal = decimal.TryParse(item, out decimal resultDecimal);

                if (isDecimal)
                {
                    if (resultDecimal > 13)
                    {
                        listOut.Add(resultDecimal);
                    }
                    else
                    {
                        listOut.Add((int)resultDecimal);
                    }
                }
                else
                {
                    listOut.Add(item);
                }
            }

            return listOut;
        }
    }
}
