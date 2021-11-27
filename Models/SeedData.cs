using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcLibrary.Data;
using System;
using System.Linq;

namespace MvcLibrary.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcLibraryContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcLibraryContext>>()))
            {
                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        Title = "A Simple Plan",
                        Author = "Scott Smith",
                        PublicationDate = DateTime.Parse("1989-2-12"),
                        Genre = "Suspense",
                        Pages = 200
                    },

                    new Book
                    {
                        Title = "Sneaky People",
                        Author = "Thomas Berger",
                        PublicationDate = DateTime.Parse("1989-2-12"),
                        Genre = "Contemporary Literature",
                        Pages = 320
                    },

                    new Book
                    {
                        Title = "True Confessions",
                        Author = "John Gregory Dunne",
                        PublicationDate = DateTime.Parse("1977-2-12"),
                        Genre = "Mystery",
                        Pages = 200
                    },

                    new Book
                    {
                        Title = "The Quiet American",
                        Author = "Graham Greene",
                        PublicationDate = DateTime.Parse("1955-2-12"),
                        Genre = "Political Fiction",
                        Pages = 200
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
