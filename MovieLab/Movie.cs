using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieLab
{
    internal class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public Movie(string titles, string categories)
        {
            this.Title = titles;
            this.Category = categories;
        }
    }
}
