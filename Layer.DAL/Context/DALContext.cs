using Layer.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Layer.DAL.Context
{
    public class DALContext : DbContext
    {
        public DALContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<School> Schools { get;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>(builder => {
                builder.HasKey(s => s.Id);
                builder.Property(s => s.Name);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
