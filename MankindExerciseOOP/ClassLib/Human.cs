using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName
        {
            get => firstName;
            set
            {
                if (value.Substring(0, 1) == value.Substring(0, 1).ToLower())
                {
                    string anfangsBuchstabe = value.Substring(0, 1).ToUpper();
                    string restString = value.Remove(0, 1);

                    firstName = anfangsBuchstabe + restString;
                }
                else
                {
                    firstName = value;
                }
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                if (value.Substring(0, 1) == value.Substring(0, 1).ToLower())
                {
                    string anfangsBuchstabe = value.Substring(0, 1).ToUpper();
                    string restString = value.Remove(0, 1);

                    lastName = anfangsBuchstabe + restString;
                }
                else
                {
                    lastName = value;
                }
            }
        }
    }
}
