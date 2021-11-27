using System.ComponentModel.DataAnnotations;

namespace MvcLibrary.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }

        [Display(Name = "Published")]
        [DisplayFormat(DataFormatString = "{0:yyyy}")]
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
        public string? Genre { get; set; }
        public int Pages { get; set; }
    }
}
