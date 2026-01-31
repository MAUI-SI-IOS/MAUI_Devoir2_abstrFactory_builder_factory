using Data.v2.Product.Basement;
using Data.v2.Product.Interior;
using Data.v2.Product.Roof;
using Data.v2.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.v2.Building
{
    internal class Duplex : IBuilding
    {
        IBasement basement;
        IStructure structure;
        IInterior interior;
        IRoof roof;

        public void setBasement(IBasement basement)
        {
            this.basement = basement;
        }

        public void setStructure(IStructure structure)
        {
            this.structure = structure;
        }
        public void setInterior(IInterior interior)
        {
            this.interior = interior;  
        }

        public void setRoof(IRoof roof)
        {
            this.roof = roof;
        }
        public string Display()
        {
            return $"This duplex as: {basement.display()}, {structure.display()}, {interior.display()}, {roof.display()}";
        }
    }
}
