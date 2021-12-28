using Microsoft.EntityFrameworkCore;
namespace CSharpExam.Models
{ 
    
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        
        public DbSet<User> Users { get; set; }
        public DbSet<Attending> Attendings { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
    }
}

//dotnet ef migrations add FirstMigration
//dotnet ef database update

