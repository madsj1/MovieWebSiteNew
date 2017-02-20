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
                MovieGenres = "Sci-fi",
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
                MovieGenres = "Adventure",
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
                MovieGenres = "Drama",
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
                MovieGenres = "Action",
                MovieImageURL = "http://ia.media-imdb.com/images/M/MV5BMjM2Nzg4MzkwOF5BMl5BanBnXkFtZTgwNzA0OTE3NjE@._V1_SX214_AL_.jpg",
                MovieTrailerURL = "https://www.youtube.com/embed/7GqClqvlObY",
                MovieRelease = new DateTime(2015, 10, 30),
                MovieDescription = "A cryptic message from Bond's past sends him on a trail to uncover a sinister organization." +
                "While M battles political forces to keep the secret service alive, Bond peels back the layers of deceit to reveal the terrible truth behind SPECTRE."
            };
            context.Movies.Add(moviefour);

            Movie moviefive = new Movie()
            {
                MovieID = 5,
                MovieTitle = "Doctor Strange",
                MovieGenres = "Fantasy",
                MovieImageURL = "https://images-na.ssl-images-amazon.com/images/M/MV5BNTA2NTg0MjM0OV5BMl5BanBnXkFtZTgwNTEyMDExMTI@._V1_SY1000_CR0,0,729,1000_AL_.jpg",
                MovieTrailerURL = "https://www.youtube.com/embed/HSzx-zryEgM",
                MovieRelease = new DateTime(2016, 11, 4),
                MovieDescription = "A former neurosurgeon embarks on a journey of healing only to be drawn into the world of the mystic arts."
            };
            context.Movies.Add(moviefive);

            Movie moviesix = new Movie()
            {
                MovieID = 6,
                MovieTitle = "Jurassic World",
                MovieGenres = "Action, Sci-fi",
                MovieImageURL = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTQ5MTE0MTk3Nl5BMl5BanBnXkFtZTgwMjczMzk2NTE@._V1_SY1000_CR0,0,631,1000_AL_.jpg",
                MovieTrailerURL = "https://www.youtube.com/embed/XvEDQzWXS_s",
                MovieRelease = new DateTime(2016, 6, 12),
                MovieDescription = "A new theme park, built on the original site of Jurassic Park, creates a genetically modified hybrid dinosaur, which escapes containment and goes on a killing spree."
            };
            context.Movies.Add(moviesix);

            Movie movieseven = new Movie()
            {
                MovieID = 7,
                MovieTitle = "Logan",
                MovieGenres = "Action, Sci-fi",
                MovieImageURL = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjI1MjkzMjczMV5BMl5BanBnXkFtZTgwNDk4NjYyMTI@._V1_SY1000_CR0,0,676,1000_AL_.jpg",
                MovieTrailerURL = "https://www.youtube.com/embed/DekuSxJgpbY",
                MovieRelease = new DateTime(2016, 3, 3),
                MovieDescription = "In the near future, a weary Logan cares for an ailing Professor X in a hide out on the Mexican border." +
                " But Logan's attempts to hide from the world and his legacy are up-ended when a young mutant arrives, being pursued by dark forces."
            };
            context.Movies.Add(movieseven);

            Movie movieeight = new Movie()
            {
                MovieID = 8,
                MovieTitle = "John Wick",
                MovieGenres = "Action",
                MovieImageURL = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTU2NjA1ODgzMF5BMl5BanBnXkFtZTgwMTM2MTI4MjE@._V1_SY1000_CR0,0,666,1000_AL_.jpg",
                MovieTrailerURL = "https://www.youtube.com/embed/C0BMx-qxsP4",
                MovieRelease = new DateTime(2014, 10, 24),
                MovieDescription = "An ex-hitman comes out of retirement to track down the gangsters that took everything from him."
            };
            context.Movies.Add(movieeight);

            Movie movienine = new Movie()
            {
                MovieID = 9,
                MovieTitle = "Edge of Tomorrow",
                MovieGenres = "Action, Sci-fi",
                MovieImageURL = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTc5OTk4MTM3M15BMl5BanBnXkFtZTgwODcxNjg3MDE@._V1_SY1000_CR0,0,674,1000_AL_.jpg",
                MovieTrailerURL = "https://www.youtube.com/embed/yUmSVcttXnI",
                MovieRelease = new DateTime(2014, 6, 6),
                MovieDescription = "A soldier fighting aliens gets to relive the same day over and over again, the day restarting every time he dies."
            };
            context.Movies.Add(movienine);

            Movie movieten = new Movie()
            {
                MovieID = 10,
                MovieTitle = "Power Rangers",
                MovieGenres = "Sci-fi",
                MovieImageURL = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTA5MzU1NDI4NzBeQTJeQWpwZ15BbWU4MDUxMDQ0NDEy._V1_SY1000_CR0,0,674,1000_AL_.jpg",
                MovieTrailerURL = "https://www.youtube.com/embed/5kIe6UZHSXw",
                MovieRelease = new DateTime(2017, 3, 24),
                MovieDescription = "A group of high-school kids, who are infused with unique superpowers, harness their abilities in order to save the world."
            };
            context.Movies.Add(movieten);

            List<Movie> genreonemovie = new List<Movie>();
            genreonemovie.Add(MovieOne);
            genreonemovie.Add(movietwo);
            Genre genreone = new Genre() { Movies = genreonemovie, Name = "Action" };
            context.Genres.Add(genreone);

            List<Movie> genretwomovie = new List<Movie>();
            genretwomovie.Add(MovieOne);
            genretwomovie.Add(movietree);
            Genre genretwo = new Genre() { Movies = genretwomovie, Name = "Drama" };
            context.Genres.Add(genretwo);

            List<Movie> genrethreemovie = new List<Movie>();
            genrethreemovie.Add(MovieOne);
            genrethreemovie.Add(moviefour);
            Genre genrethree = new Genre() { Movies = genrethreemovie, Name = "Adventure" };
            context.Genres.Add(genrethree);

            List<Movie> genrefourmovie = new List<Movie>();
            genrefourmovie.Add(MovieOne);
            genrefourmovie.Add(moviefour);
            Genre genrefour = new Genre() { Movies = genrefourmovie, Name = "Sifi" };
            context.Genres.Add(genrefour);



            base.Seed(context);
        }
    }
}