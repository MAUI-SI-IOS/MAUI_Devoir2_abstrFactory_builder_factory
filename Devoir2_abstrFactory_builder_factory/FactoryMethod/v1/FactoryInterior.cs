using Devoir2_abstrFactory_builder_factory.Data.v1;
using Devoir2_abstrFactory_builder_factory.Data.v1.Product.Interior;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.FactoryMethod.v1
{
    internal class FactoryInterior
    {
        public static IInterior Factory(ProductType type)
        {
            switch (type)
            {
                case ProductType.Quebecois:
                    return new QuebecoisInterior();
                case ProductType.Persian:
                    return new PersianInterior();
                case ProductType.Modern:
                    return new ModernInterior();

                default: throw new UnreachableException("Bad token");
            }
        }
    }
}
