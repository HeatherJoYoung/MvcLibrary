using System.ComponentModel.DataAnnotations;
#nullable enable

namespace MvcLibrary.Models
{
    public class Book : LibraryItem
    {
        [Required]
        public string? Author { get; set; }

        public int? Pages { get; set; }

        public Book()
        {
            Type = ItemType.Book;
        }
    }
}
