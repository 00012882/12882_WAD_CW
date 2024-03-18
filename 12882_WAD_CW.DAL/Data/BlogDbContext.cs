using _12882_WAD_CW.Models;
using Microsoft.EntityFrameworkCore;

namespace _12882_WAD_CW.Data
{
    public class BlogDbContext : DbContext
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
