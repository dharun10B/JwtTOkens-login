using Microsoft.EntityFrameworkCore;
using JwtTOkens.Models;

namespace InstituteManagement.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
