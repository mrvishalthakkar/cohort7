using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public static class SeedData
    {
       
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                foreach (var movie in context.Movie)
                {
                    context.Remove(movie);
                }
                context.SaveChanges();
          
                if (context.Movie.Any())
                {
                    return; //exit because db is seeded
                }
                {
                    context.AddRange(
                        new Movie
                        {
                            Title = "When Harry Met Sally",
                            ReleaseDate = DateTime.Parse("1989-1-11"),
                            Genre = "Romantic Comedy",
                            Price = 7.99M,
                            Rating = "R"

                        },

                        new Movie
                        {
                            Title = "Kal ho na ho",
                            ReleaseDate = DateTime.Parse("2008-1-12"),
                            Genre = "Drama",
                            Price = 8.88M,
                            Rating = "PG"
                        },

                        new Movie
                        {
                            Title = "Dostana",
                            ReleaseDate = DateTime.Parse("2009-2-10"),
                            Genre = "Comedy",
                            Price = 5.99M,
                            Rating = "PG"
                        }
                        );
                    context.SaveChanges();
                }
            }
        } 
    }
}
