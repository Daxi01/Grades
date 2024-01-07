namespace Grades
{
    using Microsoft.EntityFrameworkCore;
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options) 
        {
        }

        public DbSet<Credit> Credits { get; set; }
    }
}
