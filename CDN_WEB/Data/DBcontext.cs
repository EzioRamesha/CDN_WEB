using CDN_WEB.Models;
using Microsoft.EntityFrameworkCore;


namespace CDN_WEB.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }

}
