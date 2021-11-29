
using System.ComponentModel.DataAnnotations;
#nullable enable

namespace MvcLibrary.Models
{
    public class Movie : LibraryItem
    {
        public string? Studio { get; set; }

        public string? Director { get; set; }

        public string? Actor { get; set; }

        [Required]
        public string? Rating { get; set; }

        public Movie()
        { 
            Type = ItemType.Movie;
        }

        //public Movie(string title, string? studio, string? director, string? actor, string rating, DateTime? publicationDate, string? genre)
        //{
        //    Title = title;
        //    Studio = studio;
        //    Director = director;
        //    Actor = actor;
        //    Rating = rating;
        //    PublicationDate = publicationDate;
        //    Genre = genre;
        //    Type =  ItemType.Movie;
        //}
    }
}
