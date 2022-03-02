using Layer.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Layer.DAL.Context
{
    public class DALContext : DbContext
    {
        public DbSet<School> Schools { get;}
    }
}
