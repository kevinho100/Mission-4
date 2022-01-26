using System;
using Microsoft.EntityFrameworkCore;

namespace FilmCollection.Models
{
    public class MovieApplicationContext : DbContext
    {
        //constructor
        public MovieApplicationContext(DbContextOptions<MovieApplicationContext> options) :base(options)
        {
            //leave blank
        }

        public DbSet<ApplicationResponse> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieID = 1,
                    Category = "Action/Adventure",
                    Title = "Spider-Man: No way home",
                    Year = 2022,
                    Director = "Jon Watts",
                    Rating = "PG-13",
                    Edited = false,
                    LenTo = "",
                    Notes = "Best movie of 2022"
                },

                new ApplicationResponse
                {
                    MovieID = 2,
                    Category = "Action/Adventure",
                    Title = "Avengers:Endgame",
                    Year = 2019,
                    Director = "Kevin Feige",
                    Rating = "PG-13",
                    Edited = false,
                    LenTo = "",
                    Notes = "Best movie of 2019"
                },

                new ApplicationResponse
                {
                    MovieID = 3,
                    Category = "Action/Adventure",
                    Title = "Avengers:Infinity War",
                    Year = 2018,
                    Director = "Jon Watts",
                    Rating = "PG-13",
                    Edited = false,
                    LenTo = "",
                    Notes = "Best movie of 2018"
                }


                );
        }
    }
}
