using Layer.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace Layer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            var service = new SchoolService();

            var school = await service.Get(id);

            return Ok(school);
        }
    }
}