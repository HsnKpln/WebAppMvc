namespace WebAppMvc.Core.Entities
{
    public interface IEntity<TKey>
    {
        public TKey Id { get; set; }
    }
}
