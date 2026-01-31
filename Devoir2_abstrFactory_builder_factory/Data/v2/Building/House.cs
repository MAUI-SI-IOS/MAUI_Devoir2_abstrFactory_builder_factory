using Data.v2.Product.Basement;
using Data.v2.Product.Interior;
using Data.v2.Product.Roof;
using Data.v2.Product.Structure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.v2.Building
{
    internal class House : IBuilding
    {
        IBasement   basement;
        IStructure  structure;
        IInterior   interior;
        IRoof       roof;

        public void setBasement(IBasement basement)
        {
            this.basement = basement;
        }

        public void setInterior(IInterior interior)
        {
            this.interior = interior;
        }
        public void setStructure(IStructure structure)
        {
            this.structure = structure;
        }

        public void setRoof(IRoof roof)
        {
            this.roof = roof;
        }
        public string Display() // for test
        {
           return $"This house as: {basement.display()}, {structure.display()}, {interior.display()}, {roof.display()}";
        }
    }
}
