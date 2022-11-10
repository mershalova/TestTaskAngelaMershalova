using Microsoft.AspNetCore.Mvc;
using TestTaskAngelaMershalova.Models.DTO;
using TestTaskAngelaMershalova.Repositories.Interfaces;

namespace TestTaskAngelaMershalova.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController: ControllerBase
    {
        protected readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AccountDTO dto)
        {
            var res = await _accountService.CreateAccountAsync(dto);
            return Ok(res);
        }
        [HttpGet]
        [Route("collection")]
        public async Task<IActionResult> GetAccounts()
        {
            return Ok( await _accountService.GetAllAccountsAsync());
        }
    }
}
