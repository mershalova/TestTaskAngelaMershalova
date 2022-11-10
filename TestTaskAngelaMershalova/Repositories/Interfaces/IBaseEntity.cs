namespace TestTaskAngelaMershalova.Interfaces
{ 
    public interface IBaseEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
