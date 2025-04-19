using FactoryMethod.Contracts;

namespace FactoryMethod.Implementations
{
    class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct1();
        }
    }
}
