using Microsoft.EntityFrameworkCore;

namespace AdminWebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext( DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }
    }
}
