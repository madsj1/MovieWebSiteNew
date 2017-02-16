using MovieWebSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MovieWebSite.DAL
{
    public class MovieDBInitializer : DropCreateDatabaseAlways<MovieContext>
    {
        protected override void Seed(MovieContext context)
        {
            Movie MovieOne = new Movie()
            {
                MovieID = 1,
                MovieTitle = "The Martian",
                MovieGenres = null,
                MovieImageURL = "http://ia.media-imdb.com/images/M/MV5BMTc2MTQ3MDA1Nl5BMl5BanBnXkFtZTgwODA3OTI4NjE@._V1__SX1473_SY687_.jpg",
                MovieTrailerURL = "https://www.youtube.com/embed/ej3ioOneTy8",
                MovieRelease = new DateTime(2015, 10, 8),
                MovieDescription = "During a manned mission to Mars, Astronaut Mark Watney is presumed dead after a fierce storm and left" +
                "behind by his crew. But Watney has survived and finds himself stranded and alone on the hostile planet. With only meager" +
                "supplies, he must draw upon his ingenuity, wit and spirit to subsist and find a way to signal to Earth that he is alive."
            };
            context.Movies.Add(MovieOne);

            Movie movietwo = new Movie()
            {
                MovieID = 2,
                MovieTitle = "A walk in the woods",
                MovieGenres = null,
                MovieImageURL = "http://ia.media-imdb.com/images/M/MV5BMTU2MTkwMzM0NF5BMl5BanBnXkFtZTgwMjA0NDA4NTE@._V1__SX1473_SY687_.jpg",
                MovieTrailerURL = "https://www.youtube.com/embed/suK1e_3zNHg",
                MovieRelease = new DateTime(2015, 9, 2),
                MovieDescription = "After spending two decades in England," +
               "Bill Bryson returns to the U.S.," +
               "where he decides the best way to connect with his homeland is to hike the Appalachian Trail with one of his oldest friends."
            };
            context.Movies.Add(movietwo);

            Movie movietree = new Movie()
            {
                MovieID = 3,
                MovieTitle = "The shawshank redemption",
                MovieGenres = null,
                MovieImageURL = "http://ia.media-imdb.com/images/M/MV5BODU4MjU4NjIwNl5BMl5BanBnXkFtZTgwMDU2MjEyMDE@._V1__SX1473_SY687_.jpg",
                MovieTrailerURL = "https://www.youtube.com/embed/6hB3S9bIaco",
                MovieRelease = new DateTime(1995, 4, 28),
                MovieDescription = "Two imprisoned men bond over a number of years," +
                "finding solace and eventual redemption through acts of common decency."
            };
            context.Movies.Add(movietree);

            Movie moviefour = new Movie()
            {
                MovieID = 4,
                MovieTitle = "Spectre",
                MovieGenres = null,
                MovieImageURL = "http://ia.media-imdb.com/images/M/MV5BMjM2Nzg4MzkwOF5BMl5BanBnXkFtZTgwNzA0OTE3NjE@._V1_SX214_AL_.jpg",
                MovieTrailerURL = "https://www.youtube.com/watch?v=LTDaET-JweU",
                MovieRelease = new DateTime(2015, 10, 30),
                MovieDescription = "A cryptic message from Bond's past sends him on a trail to uncover a sinister organization." +
                "While M battles political forces to keep the secret service alive, Bond peels back the layers of deceit to reveal the terrible truth behind SPECTRE."
            };
            context.Movies.Add(moviefour);

            base.Seed(context);
        }
    }
}