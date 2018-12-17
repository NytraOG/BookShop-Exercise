using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class GoldenEditionBook : Book
    {
        private const decimal GoldAufschlag = 1.3m;
        private const string Description = "Golden Edition Book";

        public GoldenEditionBook(string title, string author, decimal price) : base(title, author, price)
        {
        }

        public override string Author { get; set; }
        public override string Title { get; set; }
        public override decimal Price
        {
            get => price;
            set => price = GoldAufschlag * value;
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
