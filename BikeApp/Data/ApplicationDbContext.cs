using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BikeApp.Models;

namespace BikeApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<BikeApp.Models.BikeRoute> BikeRoutes { get; set; } = default!;
        public DbSet<BikeApp.Models.Event> Events { get; set; } = default!;
    }
}