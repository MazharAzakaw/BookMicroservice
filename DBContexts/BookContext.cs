using BookMicroservice.Models;
using Microsoft.EntityFrameworkCore;

namespace BookMicroservice.DBContexts
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }

    }
}
