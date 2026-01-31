using Data.v2.Building;
using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.v2
{
    internal interface IBuilder
    {
        IBuilder buildBasement();
        IBuilder buildStructure();
        IBuilder buildInterior();
        IBuilder buildRoof();
        IBuilding make();
    }
}
