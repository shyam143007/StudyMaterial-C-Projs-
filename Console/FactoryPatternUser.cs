using FactoryPattern;

namespace Console
{
    public class FactoryPatternUser
    {
        static void Main(string[] args)
        {
            FactoryPatternAPI api = new FactoryPatternAPI();
            //product related operations
            IEntity product = api.GetProduct();

            product.Add();
            product.Delete();

            //Order related operations
            IOrder order = api.GetOrder();

            order.Add();
            order.Delete();
        }
    }
}
