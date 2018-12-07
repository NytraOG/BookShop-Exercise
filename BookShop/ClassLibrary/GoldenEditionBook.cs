using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class GoldenEditionBook : Book
    {
        private const decimal GoldAufschlag = 1.3m;

        public GoldenEditionBook(string title, string author, decimal price, string description) : base(title, author, price, description)
        {
        }

        public override string Description { get; set; }
        public override string Author { get; set; }
        public override string Title { get; set; }
        public override decimal Price
        {
            get => price;
            set => price = GoldAufschlag * value;
        }
    }
}
