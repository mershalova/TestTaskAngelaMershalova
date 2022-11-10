using System.ComponentModel.DataAnnotations.Schema;
using TestTaskAngelaMershalova.Interfaces;
using TestTaskAngelaMershalova.Models.AccountEntity;

namespace TestTaskAngelaMershalova.Models.ContactEntity
{
    [Table("Contacts", Schema = "TestTask")]
    public class Contact : IBaseEntity<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? AccountId { get; set; }
        public Account? Account { get; set; }
    }
}
