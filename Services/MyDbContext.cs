using Library.Data;
using Microsoft.EntityFrameworkCore;

namespace Library.Services
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Books> Books { get; set; }
        public DbSet<Songs> Songs { get; set; }
        public DbSet<Podcasts> Podcasts { get; set; }
        public DbSet<Audiobooks> Audiobooks { get; set; }

    }
}
