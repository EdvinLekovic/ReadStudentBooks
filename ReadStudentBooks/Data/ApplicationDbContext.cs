using Microsoft.EntityFrameworkCore;
using ReadStudentBooks.Models;

namespace ReadStudentBooks.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; } 
        public DbSet<User> Users { get; set; }

    }
}
