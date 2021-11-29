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
                // Look for any library items.
                if (context.LibraryItems.Any())
                {
                    return;   // DB has been seeded
                }

                context.LibraryItems.AddRange(
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
                    },
                    new Album
                    { 
                        Title = "Country Stuff",
                        Artist = "Walker Hayes",
                        IsSoloArtist = true,
                        PublicationDate = DateTime.Parse("2021-8-2"),
                        Genre = "Country"
                    },
                     new Movie
                     {
                         Title = "Seven Samurai",
                         Director = "Akira Kurosawa",
                         Actor = "Toshiro Mifune",
                         PublicationDate = DateTime.Parse("1954-1-1"),
                         Genre = "Action"
                     },
                     new Movie
                     { 
                        Title = "Do the Right Thing",
                        Director = "Spike Lee",
                        Actor = "Ossie Davis",
                        PublicationDate = DateTime.Parse("1989-1-1"),
                        Genre = "Comedy"
                     },
                     new Movie
                     {
                         Title = "Once Upon a Time in Hollywood",
                         Director = "Quentin Tarantino",
                         Actor = "Brad Pitt",
                         PublicationDate = DateTime.Parse("2019-7-26"),
                         Genre = "Drama"
                     }
                );
                context.SaveChanges();
            }
        }
    }
}
