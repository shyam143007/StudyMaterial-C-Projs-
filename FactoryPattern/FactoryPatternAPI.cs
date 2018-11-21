namespace FactoryPattern
{
    public class FactoryPatternAPI
    {
        public Product GetProduct()
        {
            return new Repository().GetRepository<Product>();             
        }

        public Order GetOrder()
        {
            return new Repository().GetRepository<Order>();
        }
    }
}
