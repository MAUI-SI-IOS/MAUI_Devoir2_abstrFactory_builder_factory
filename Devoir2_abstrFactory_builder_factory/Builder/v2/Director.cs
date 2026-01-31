using Data.v2.Building;
using Devoir2_abstrFactory_builder_factory.Builder.v2;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Builder.v2
{
    internal class Director
    {
        IBuilder builder;
        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public IBuilding build()
        {
            return builder.buildBasement()
                          .buildStructure()
                          .buildInterior()
                          .buildRoof()
                          .make();
        }
    }
}
