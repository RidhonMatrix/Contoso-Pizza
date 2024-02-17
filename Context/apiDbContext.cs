using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Context
{
    public class apiDbContext:DbContext
    {
        public apiDbContext(DbContextOptions<apiDbContext> options) : base(options) 
        { 
            
        }
        public DbSet<Post> Posts {  get; set; }
    }
}
