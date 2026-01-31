using Devoir2_abstrFactory_builder_factory.Data.v2.Product.Basement;
using Devoir2_abstrFactory_builder_factory.Data.v2.Product.Interior;
using Devoir2_abstrFactory_builder_factory.Data.v2.Product.Roof;
using Devoir2_abstrFactory_builder_factory.Data.v2.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.v2
{
    internal class PersianFactory: IAbstractFactory
    {
        public IBasement makeBasement()
        {
            return new PersianBasement();
        }
        public IStructure makeStructure()
        {
            return new PersianStructure();
        }

        public IInterior makeInterior()
        {
            return new PersianInterior();
        }

        public IRoof makeRoof()
        {
            return new PersianRoof();
        }
    }
}
