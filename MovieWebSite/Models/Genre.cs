using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieWebSite.Models
{
    public class Genre
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<Movie> Movies { get; set; }
    }
}