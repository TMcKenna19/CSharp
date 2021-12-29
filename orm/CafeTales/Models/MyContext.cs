using Microsoft.EntityFrameworkCore;
namespace CafeTales.Models
{ 

    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Coffee> Coffees { get; set; }  
        
    }
}  