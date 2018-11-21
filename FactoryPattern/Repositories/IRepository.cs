namespace FactoryPattern
{
    /// <summary>
    /// IRepository is the base for getting repositories
    /// </summary>
    public interface IRepository
    {
        T GetRepository<T>() where T : new();
    }
}
