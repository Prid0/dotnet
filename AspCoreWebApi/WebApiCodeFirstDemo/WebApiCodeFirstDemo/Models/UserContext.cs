using Microsoft.EntityFrameworkCore;

namespace WebApiCodeFirstDemo.Models
{
    public class UserContext : DbContext

    {
        public UserContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<UserModel> Users { get; set; }
    }
}
