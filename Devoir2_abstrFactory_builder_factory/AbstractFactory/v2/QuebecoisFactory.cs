using Devoir2_abstrFactory_builder_factory.AbstractFactory.v2;
using Devoir2_abstrFactory_builder_factory.Data.v2.Product.Basement;
using Devoir2_abstrFactory_builder_factory.Data.v2.Product.Interior;
using Devoir2_abstrFactory_builder_factory.Data.v2.Product.Roof;
using Devoir2_abstrFactory_builder_factory.Data.v2.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.v2
{
    internal class QuebecoisFactory : IAbstractFactory
    {
        public IBasement makeBasement()
        {
            return new QuebecoisBasement();
        }
        public IStructure makeStructure()
        {
            return new QuebecoisStructure();
        }

        public IInterior makeInterior()
        {
            return new QuebecoisInterior();
        }

        public IRoof makeRoof()
        {
            return new QuebecoisRoof();
        }


    }
}
