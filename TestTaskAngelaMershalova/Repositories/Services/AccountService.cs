using AutoMapper;
using TestTaskAngelaMershalova.Interfaces;
using TestTaskAngelaMershalova.Models.AccountEntity;
using TestTaskAngelaMershalova.Models.ContactEntity;
using TestTaskAngelaMershalova.Models.DTO;
using TestTaskAngelaMershalova.Repositories.Interfaces;

namespace TestTaskAngelaMershalova.Repositories.Services
{
    public class AccountService : IAccountService
    {
        protected readonly IRepository<Account, int> _accountRepository;
        protected readonly IRepository<Contact, int> _contactRepository;
        protected readonly IMapper _mapper;

        public AccountService(IRepository<Account, int> accountRepository,
            IRepository<Contact, int> contactRepository,
            IMapper mapper)
        {
            _accountRepository = accountRepository;
            _contactRepository = contactRepository;
            _mapper = mapper;
        }

        public async Task<AccountDTO> CreateAccountAsync(AccountDTO dto)
        {
            var account = _mapper.Map<Account>(dto);
            await _accountRepository.AddAsync(account);
            await _accountRepository.SaveChangesAcync();
            var res = _mapper.Map<AccountDTO>(account);
            return res;
        }
        public async Task<IEnumerable<AccountDTO>> GetAllAccountsAsync()
        {
            var accounts = await _accountRepository.GetAllAsync();
            var res = _mapper.Map<IEnumerable<AccountDTO>>(accounts);
            return res;
        }
    }
}
