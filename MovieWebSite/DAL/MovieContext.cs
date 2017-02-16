using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using MovieWebSite.Models;  

namespace MovieWebSite.DAL
{
    public class MovieContext : DbContext
    {
        public MovieContext(): base("MovieContext")
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasMany(x => x.MovieGenres).WithMany(x => x.Movies);
        }
    }
}