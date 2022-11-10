namespace TestTaskAngelaMershalova.Models.DTO
{
    public class IncedentDTO
    {
        public string Id { get; set; }
        public string? Description { get; set; }
        public List<AccountDTO> Accounts { get; set; }

    }
}
