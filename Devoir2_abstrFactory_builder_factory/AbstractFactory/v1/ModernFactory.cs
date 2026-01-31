
using Data.v1.Product.Basement;
using Data.v1.Product.Interior;
using Data.v1.Product.Roof;
using Data.v1.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.v1
{
    internal class ModernFactory : IAbstractFactory
    {
        public IBasement makeBasement()
        {
            return new ModernBasement();
        }

        public IInterior makeInterior()
        {
            return new ModernInterior();
        }

        public IRoof makeRoof()
        {
            return new ModernRoof();
        }

        public IStructure makeStructure()
        {
            return new ModernStructure();
        }
    }
}
