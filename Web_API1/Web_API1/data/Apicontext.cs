using Microsoft.EntityFrameworkCore;
using Web_API1.model;

namespace Web_API1.data
{
    public class Apicontect : DbContext
    {
        public DbSet<hotelBookng> Booking { get; set; }
        public Apicontext(DbContextOptions<Apicontect> options) : base(options)
        {

        }
    }
}
