﻿using FactoryMethod.Contracts;

namespace FactoryMethod.Implementations
{
    class ConcreteCreator2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}
