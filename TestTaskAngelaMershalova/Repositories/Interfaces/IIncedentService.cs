using TestTaskAngelaMershalova.Models.DTO;
using TestTaskAngelaMershalova.Models.IncedentEntity;

namespace TestTaskAngelaMershalova.Repositories.Interfaces
{
    public interface IIncedentService
    {
        Task<IncedentDTO?> CreateIncedentAsync(IncedentRequestDTO dto);
        Task<IncedentDTO> GetIncedentByIdAsync(string id);
    }
}
