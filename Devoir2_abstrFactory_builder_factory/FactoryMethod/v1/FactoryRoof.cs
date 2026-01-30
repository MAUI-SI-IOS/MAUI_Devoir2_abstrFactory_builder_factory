using Devoir2_abstrFactory_builder_factory.Data;
using Devoir2_abstrFactory_builder_factory.Data.Product.Roof;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.FactoryMethod.v1
{
    internal class FactoryRoof
    {
        public static IRoof Factory(ProductType type)
        {
            switch (type)
            {
                case ProductType.Quebecois:
                    return new QuebecoisRoof();
                case ProductType.Persian:
                    return new PersianRoof();
                case ProductType.Modern:
                    return new ModernRoof();

                default: throw new UnreachableException("Bad token");
            }
        }
    }
}
