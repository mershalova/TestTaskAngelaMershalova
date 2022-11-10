using AutoMapper;
using TestTaskAngelaMershalova.Models.AccountEntity;
using TestTaskAngelaMershalova.Models.ContactEntity;
using TestTaskAngelaMershalova.Models.DTO;
using TestTaskAngelaMershalova.Models.IncedentEntity;

namespace TestTaskAngelaMershalova
{
    public class ApplicationProfile: Profile
    {
        public ApplicationProfile()
        {
            CreateMap<IncedentDTO, Incedent>().ReverseMap();
            CreateMap<AccountDTO, Account>().ReverseMap();
            CreateMap<ContactDTO, Contact>().ReverseMap();
            CreateMap<IncedentRequestDTO, Contact>().ReverseMap();
            CreateMap<IncedentRequestDTO, Incedent>().ReverseMap();
        }
    }
}
