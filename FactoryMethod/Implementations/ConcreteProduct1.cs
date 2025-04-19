using FactoryMethod.Contracts;

namespace FactoryMethod.Implementations
{
    public class ConcreteProduct1 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct1}";
        }
    }
}
