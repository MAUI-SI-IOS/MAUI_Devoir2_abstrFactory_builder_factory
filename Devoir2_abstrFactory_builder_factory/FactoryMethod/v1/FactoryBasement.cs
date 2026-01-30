using Devoir2_abstrFactory_builder_factory.Data;
using Devoir2_abstrFactory_builder_factory.Data.Product.Basement;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.FactoryMethod.v1
{
    internal class FactoryBasement
    {
        public static IBasement Factory(ProductType type)
        {
            switch(type)
            {
                case ProductType.Quebecois:
                    return new QuebecoisBasement();
                case ProductType.Persian:
                    return new PersianBasement();
                case ProductType.Modern:
                    return new ModernBasement();

                default: throw new UnreachableException("Bad token");
            }
        }
    }
}
