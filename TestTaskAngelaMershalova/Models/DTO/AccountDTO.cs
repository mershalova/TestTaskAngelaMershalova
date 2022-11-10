using TestTaskAngelaMershalova.Models.ContactEntity;
using TestTaskAngelaMershalova.Models.IncedentEntity;

namespace TestTaskAngelaMershalova.Models.DTO
{
    public class AccountDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ContactDTO> Contacts { get; set; }
    }
}
