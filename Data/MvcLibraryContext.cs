using Microsoft.EntityFrameworkCore;
using MvcLibrary.Models;

namespace MvcLibrary.Data
{
    public class MvcLibraryContext : DbContext
    {
        public MvcLibraryContext(DbContextOptions<MvcLibraryContext> options)
            : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<LibraryItem> LibraryItems { get; set; }
        public DbSet<Movie> Movies { get; set; }
    }
}
