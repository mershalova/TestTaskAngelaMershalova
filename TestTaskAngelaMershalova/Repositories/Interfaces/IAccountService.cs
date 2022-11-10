using TestTaskAngelaMershalova.Models.DTO;

namespace TestTaskAngelaMershalova.Repositories.Interfaces
{
    public interface IAccountService
    {
        Task<AccountDTO> CreateAccountAsync(AccountDTO dto);
        Task<IEnumerable<AccountDTO>> GetAllAccountsAsync();
    }
}
