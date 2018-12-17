using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Book
    {
        protected string title;
        protected string author;
        protected decimal price;
        protected const string Description = "Book";

        public Book(string author, string title, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public virtual string Title
        {
            get => title;
            set
            {
                try
                {
                    if (value.Length < 3)
                    {
                        throw new Exception("Title not valid!");
                    }

                    title = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
        public virtual string Author { get; set; }

        public virtual decimal Price
        {
            get => price;
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw  new Exception("Price not valid");
                    }

                    price = value;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        public override string ToString()
        {
            return $"\n Type: \t{Description}" +
                   $"\n Title: \t{Title}" +
                   $"\n Author: \t{Author}" +
                   $"\n Price: \t{Price}";
        }
    }
}
