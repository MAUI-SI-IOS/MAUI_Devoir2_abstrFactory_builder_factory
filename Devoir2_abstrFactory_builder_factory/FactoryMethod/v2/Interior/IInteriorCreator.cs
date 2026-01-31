using Devoir2_abstrFactory_builder_factory.Data.v2.Product.Interior;
using System;
using System.Collections.Generic;
using System.Text;

namespace Devoir2_abstrFactory_builder_factory.FactoryMethod.v2.Interior
{
    internal interface IInteriorCreator
    {
        IInterior FactoryMethod();
    }
}
