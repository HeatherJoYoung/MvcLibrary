using System.ComponentModel.DataAnnotations;
#nullable enable

namespace MvcLibrary.Models
{
    public enum ItemType
    {
        Book, Album, Movie
    }

    public class LibraryItem
    {
        [Key]
        public int ID { get; private set; }

        [Required]
        public string? Title { get; set; }

        [Display(Name = "Published")]
        [DisplayFormat(DataFormatString = "{0:yyyy}")]
        [DataType(DataType.Date)]
        public DateTime? PublicationDate { get; set; }

        public string? Genre { get; set; }

        [Required]
        public ItemType Type { get; set; }

    }
}
