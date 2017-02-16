using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieWebSite.Models
{
    public class Movie
    {
        public int MovieID { get; set; }
        public string MovieTitle { get; set; }
        public string MovieDescription { get; set; }
        public DateTime MovieRelease { get; set; }
        public List<Genre> MovieGenres { get; set; }
        public string MovieImageURL { get; set; }
        public string MovieTrailerURL { get; set; }
    }
}