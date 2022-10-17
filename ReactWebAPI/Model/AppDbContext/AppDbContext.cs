using Microsoft.EntityFrameworkCore;

namespace ReactWebAPI.Model.AppDbContext
{
    public class AppDbContext : DbContext
    {
        public DbSet<News> News { get; set; }

        public DbSet<DimNews> DimNews { get; set; }

        public DbSet<Student> students { get; set; }

        public DbSet<Vacancy> vacancies { get; set; }

        public DbSet<Admin> admins { get; set; }

        public DbSet<CallCenterQuery> callCenterRequests { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
