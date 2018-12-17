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
        private string incomingString;

        public string IncomingString
        {
            set => incomingString = value;
        }

        public StringManager(string incomingString)
        {
            IncomingString = incomingString;
        }

        public string[] SplitString()
        {
            return incomingString.Split(Separator);
        }
    }
}
