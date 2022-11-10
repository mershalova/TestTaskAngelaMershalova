using Ardalis.Specification;

namespace TestTaskAngelaMershalova.Models.AccountEntity
{
    public class AccountSpec
    {
        internal class AccountByName : Specification<Account>
        {
            public AccountByName(string name)
            {
                Query
                    .Where(x => x.Name == name);
            }
        }
    }
}
