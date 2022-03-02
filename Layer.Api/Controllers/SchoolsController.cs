using Layer.BLL.Services;
using Layer.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Layer.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
        private readonly SchoolService _service;

        public SchoolsController(SchoolService service)
        {
            this._service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var school = await _service.Get(id);

            return Ok(school);
        }

        [HttpPost]
        public async Task<IActionResult> Post(School school)
        {
            await _service.Add(school);

            return Ok(school);
        }
    }
}