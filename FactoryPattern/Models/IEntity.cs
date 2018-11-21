namespace FactoryPattern
{
    public interface IEntity
    {
        int Id { get; set; }

        void Add();

        void Delete();
    }
}
