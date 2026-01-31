using Devoir2_abstrFactory_builder_factory.Data.v1;
using Devoir2_abstrFactory_builder_factory.Data.v1.Product.Structure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace FactoryMethod.v1
{
    internal class FactoryStructure
    {
        public static IStructure Factory(ProductType type)
        {
            switch (type)
            {
                case ProductType.Quebecois:
                    return new QuebecoisStructure();
                case ProductType.Persian:
                    return new PersianStructure();
                case ProductType.Modern:
                    return new ModernStructure();

                default: throw new UnreachableException("Bad token");
            }
        }
    }
}
