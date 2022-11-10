using Ardalis.Specification;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using TestTaskAngelaMershalova.Models.AccountEntity;

namespace TestTaskAngelaMershalova.Models.ContactEntity
{
    public class ContactSpec
    {
        internal class ContactByEmail : Specification<Contact>
        {
            public ContactByEmail(string email)
            {
                Query
                    .Where(x => x.Email == email);
            }
        }
    }
}
