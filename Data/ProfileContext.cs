using FirstMVCProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMVCProject.Data
{
    public class ProfileContext : DbContext
    {
        public ProfileContext(DbContextOptions<ProfileContext> options) : base(options) { }

        public DbSet<ProfileViewModel> UserProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProfileViewModel>().ToTable("UserProfiles");
        }
    }
}
