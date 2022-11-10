using Microsoft.AspNetCore.Mvc;
using TestTaskAngelaMershalova.Models.DTO;
using TestTaskAngelaMershalova.Repositories.Interfaces;

namespace TestTaskAngelaMershalova.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class IncedentController: ControllerBase
    {
        protected readonly IIncedentService _incedentService;
        public IncedentController(IIncedentService incedentService)
        {
            _incedentService = incedentService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] IncedentRequestDTO dto)
        {
            var res = await _incedentService.CreateIncedentAsync(dto);
            return res == null ? NotFound() : Ok(res);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById([FromRoute] string id)
        {
            var res = await _incedentService.GetIncedentByIdAsync(id);
            return Ok(res);
        }
    }
}
