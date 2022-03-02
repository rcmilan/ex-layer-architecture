using Layer.DAL.Context;
using Layer.DAL.Entities;

namespace Layer.BLL.Services
{
    public class SchoolService
    {
        private DALContext _context;

        public SchoolService(DALContext context)
        {
            _context = context;
        }

        public async Task<School?> Get(int id)
        {
            var school = await _context.Set<School>().FindAsync(id);

            return school;
        }

        public async Task<School> Add(School school)
        {
            await _context.Set<School>().AddAsync(school);

            await _context.SaveChangesAsync();

            return school;
        }
    }
}