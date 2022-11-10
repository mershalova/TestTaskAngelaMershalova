using System.ComponentModel.DataAnnotations.Schema;
using TestTaskAngelaMershalova.Interfaces;
using TestTaskAngelaMershalova.Models.AccountEntity;

namespace TestTaskAngelaMershalova.Models.IncedentEntity
{
    [Table("Incedents", Schema = "TestTask")]
    public class Incedent : IBaseEntity<string>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string? Description { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}
