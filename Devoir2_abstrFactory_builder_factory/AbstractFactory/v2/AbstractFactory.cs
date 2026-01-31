using Devoir2_abstrFactory_builder_factory.Data.v2.Product.Basement;
using Devoir2_abstrFactory_builder_factory.Data.v2.Product.Interior;
using Devoir2_abstrFactory_builder_factory.Data.v2.Product.Roof;
using Devoir2_abstrFactory_builder_factory.Data.v2.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.v2
{
    internal interface IAbstractFactory
    {
        public IBasement makeBasement();
        public IStructure makeStructure();
        public IInterior makeInterior();
        public IRoof makeRoof();
    }
}
