using Entity_framework.Models;
using Microsoft.EntityFrameworkCore;

namespace Entity_framework.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        
        public DbSet<Slider> Sliders { get; set; }
            
        }

}


