using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Models{
    public class UnitContext : DbContext{
        public UnitContext(DbContextOptions<UnitContext> options) : base(options){ }
        public DbSet<Unit> Units { get; set; }
    
    
        
    }
}
