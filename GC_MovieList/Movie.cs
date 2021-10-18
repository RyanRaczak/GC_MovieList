using System;
using System.Collections.Generic;
using System.Text;

namespace GC_MovieList
{
    class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }

        public Movie(string name, string category)
        {
            this.Title = name;
            this.Category = category;
        }
    }
}
