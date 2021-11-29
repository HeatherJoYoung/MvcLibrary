
using System.ComponentModel.DataAnnotations;
#nullable enable

namespace MvcLibrary.Models
{
    public class Album : LibraryItem
    {
        [Required]
        public string? Artist { get; set; }

        public string? BandName { get; set; }

        [Required]
        public bool IsSoloArtist { get; set; }

        public Album ()
        {
            Type = ItemType.Album;
        }

        public Album(string title, string artist, string? bandName, bool isSoloArtist, DateTime? publicationDate, string? genre)
        {
            Title = title;
            Artist = artist;
            BandName = bandName;
            IsSoloArtist = isSoloArtist;
            PublicationDate = publicationDate;
            Genre = genre;
            Type = ItemType.Album;
        }
    }
}
