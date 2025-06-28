
using BlazorApp1.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1
{
    public class SeifDbContext : DbContext                                                  
    {
        public DbSet<Carsmodel>?  Carsmodel { get; set; }
        public DbSet<Users>? Users {  get; set; }
        public SeifDbContext(DbContextOptions<SeifDbContext> options):base(options) { }
    }
}
