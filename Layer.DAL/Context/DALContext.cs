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
    }
}
