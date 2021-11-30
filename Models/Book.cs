using System.ComponentModel.DataAnnotations;

namespace MvcLibrary.Models
{
    public class Book : LibraryItem
    {
        #nullable enable
        [Required]
        public string? Author { get; set; }

        public int? Pages { get; set; }

        #nullable disable
        public Book()
        {
            Type = ItemType.Book;
        }
    }
}
