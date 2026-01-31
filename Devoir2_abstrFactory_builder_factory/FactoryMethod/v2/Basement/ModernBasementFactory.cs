using Devoir2_abstrFactory_builder_factory.Data.Product.Basement;
using Devoir2_abstrFactory_builder_factory.Data.v2.Product.Basement;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.FactoryMethod.v2.Basement
{
    internal class ModernBasementFactory : IBasementCreator
    {
        public IBasement FactoryMethod()
        {
            return new ModernBasement();
        }
    }
}
