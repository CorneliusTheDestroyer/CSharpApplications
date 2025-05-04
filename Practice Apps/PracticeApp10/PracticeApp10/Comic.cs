using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp10
{
    internal class Comic
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }

        public Comic(string name, int year, string author, string publisher, string genre, int price)
        {
            Name = name;
            Year = year;
            Author = author;
            Publisher = publisher;
            Genre = genre;
            Price = price;
        }

    }
}
