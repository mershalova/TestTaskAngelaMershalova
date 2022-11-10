using AutoMapper;
using TestTaskAngelaMershalova.Interfaces;
using TestTaskAngelaMershalova.Models.AccountEntity;
using TestTaskAngelaMershalova.Models.ContactEntity;
using TestTaskAngelaMershalova.Models.DTO;
using TestTaskAngelaMershalova.Models.IncedentEntity;
using TestTaskAngelaMershalova.Repositories.Interfaces;

namespace TestTaskAngelaMershalova.Services
{
    public class IncedentService : IIncedentService
    {
        protected readonly IRepository<Incedent, string> _incedentRepository;
        protected readonly IRepository<Account, int> _accountRepository;
        protected readonly IRepository<Contact, int> _contactRepository;
        protected readonly IMapper _mapper;
        public IncedentService(IRepository<Incedent, string> incedentRepository,
            IRepository<Account, int> accountRepository,
           IRepository<Contact, int> contactRepository,
           IMapper mapper)
        {
            _incedentRepository = incedentRepository;
            _accountRepository = accountRepository;
            _contactRepository = contactRepository;
            _mapper = mapper;
        }
        public async Task<IncedentDTO?> CreateIncedentAsync(IncedentRequestDTO dto)
        {
            var specification = new AccountSpec.AccountByName(dto.Name);
            var get_acc = await _accountRepository.GetFirstBySpecAsync(specification);
            if (get_acc == null)
            {
                return null;
            }
            var cont_spec = new ContactSpec.ContactByEmail(dto.Email);
            var get_contact = await _contactRepository.GetFirstBySpecAsync(cont_spec);
            if (get_contact == null)
            {
                get_contact = _mapper.Map<Contact>(dto);
                await _contactRepository.AddAsync(get_contact);
                await _contactRepository.SaveChangesAcync();
            }
            if (get_contact.AccountId == null)
            {
                get_contact.Account = get_acc;
                await _contactRepository.UpdateAsync(get_contact);
                await _contactRepository.SaveChangesAcync();
            }
            var new_incedent = _mapper.Map<Incedent>(dto);
            await _incedentRepository.AddAsync(new_incedent);
            await _incedentRepository.SaveChangesAcync();

            get_acc.Incedent = new_incedent;

            await _accountRepository.UpdateAsync(get_acc);
            await _accountRepository.SaveChangesAcync();

            var res = _mapper.Map<IncedentDTO>(new_incedent);
            return res;
        }

        public async Task<IncedentDTO> GetIncedentByIdAsync(string id)
        {
            var specification = new IncedentSpec.GetById(id);
            var incedent = await _incedentRepository.GetFirstBySpecAsync(specification);
            var res = _mapper.Map<IncedentDTO>(incedent);
            return res;
        }
    }
}
