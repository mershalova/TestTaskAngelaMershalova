using System.ComponentModel.DataAnnotations.Schema;
using TestTaskAngelaMershalova.Interfaces;
using TestTaskAngelaMershalova.Models.ContactEntity;
using TestTaskAngelaMershalova.Models.IncedentEntity;

namespace TestTaskAngelaMershalova.Models.AccountEntity
{
    [Table("Accounts", Schema = "TestTask")]
    public class Account: IBaseEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? IncedentId { get; set; }

        public Incedent? Incedent { get; set; }
        public ICollection<Contact> Contacts { get; set; }
    }
}
