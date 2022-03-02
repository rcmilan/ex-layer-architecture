using Layer.DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Layer.DAL
{
    public static class ModuleDependency
    {

        public static void AddDALModule(this IServiceCollection services)
        {
            services.AddDbContext<DALContext>(options => options.UseSqlite($"Data Source=./db/schools.sqlite3;"));
        }
    }
}
