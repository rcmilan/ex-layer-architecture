using Layer.DAL.Entities;

namespace Layer.BLL.Services
{
    public class SchoolService
    {
        public async Task<School> Get(int id)
        {
            return new School();
        }
    }
}