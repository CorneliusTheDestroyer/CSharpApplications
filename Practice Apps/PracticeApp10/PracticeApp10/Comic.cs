using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp10
{
    internal class Comic
    {
        public int Name { get; set; }
        public int Year { get; set; }
        public int Author { get; set; }
        public int Publisher { get; set; }
        public int Genre { get; set; }
        public int Price { get; set; }

        public Comic(int name, int year, int author, int publisher, int genre, int price)
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
