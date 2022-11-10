using Ardalis.Specification;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using TestTaskAngelaMershalova.Models.ContactEntity;

namespace TestTaskAngelaMershalova.Models.IncedentEntity
{
    public class IncedentSpec
    {
        internal class GetById : Specification<Incedent>
        {
            public GetById(string id)
            {
                Query
                    .Include(x => x.Accounts)
                    .ThenInclude(x => x.Contacts)
                    .Where(x => x.Id == id);
            }
        }
    }
}
