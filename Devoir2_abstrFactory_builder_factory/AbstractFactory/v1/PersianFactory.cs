using Data.v1.Product.Basement;
using Data.v1.Product.Interior;
using Data.v1.Product.Roof;
using Data.v1.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory.v1
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
