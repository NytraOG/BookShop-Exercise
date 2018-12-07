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
        protected string description;

        public Book()
        {
            Title = title;
            Author = author;
            Price = price;
            Description = description;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }

        public virtual decimal Price
        {
            get => price;
            set => price = value;
        }
    }
}
