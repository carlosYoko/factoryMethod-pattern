using FactoryMethod.Contracts;

namespace FactoryMethod.Implementations
{
    public class ConcreteProduct2 : IProduct
    {
        public string Operation()
        {
            return "{Result of ConcreteProduct2}";
        }
    }
}
