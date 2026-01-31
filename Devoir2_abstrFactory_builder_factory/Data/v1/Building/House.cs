using Data.v1.Product.Basement;
using Data.v1.Product.Structure;
using Data.v1.Product.Interior;
using Data.v1.Product.Roof;
using System;
using System.Collections.Generic;
using System.Text;
using Data.v1.Product;



namespace Data.v1.Building
{
    internal class House 
    {
        IBasement   basement;
        IStructure  structure;
        IInterior   interior;
        IRoof       roof;

        public void setBasement(ProductType type)
        {
           
        }

        public void setInterior(ProductType type)
        {
            this.interior = interior;
        }
        public void setStructure(ProductType type)
        {
            this.structure = structure;
        }

        public void setRoof(ProductType type)
        {
            this.roof = roof;
        }
        public string Display() // for test
        {
           return $"This house as: {basement.display()}, {structure.display()}, {interior.display()}, {roof.display()}";
        }
    }
}
