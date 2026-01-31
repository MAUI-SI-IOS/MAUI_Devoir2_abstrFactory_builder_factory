using Devoir2_abstrFactory_builder_factory.Data.v2.Product.Roof;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.FactoryMethod.v2.Roof
{
    internal interface IRoofCreator<T>
    {
        IRoof FactoryMethod();
    }
}
