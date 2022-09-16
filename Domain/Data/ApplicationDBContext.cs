using Microsoft.EntityFrameworkCore;
using  Domain.Models;
namespace Domain.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions options):base(options)
        {
            
        }
      
        public DbSet<GlobalCodeCategories> GlobalCodeCategories{get; set;}
        public DbSet<GlobalCodes> GlobalCodes{get; set;}
        public DbSet<User>Users{get; set;}
    
    }
}
