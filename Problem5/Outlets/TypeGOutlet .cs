using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5.Plugs
{
    class TypeGOutlet : Outlet
    {
        public TypeGOutlet()
        {
            this.Type = OutletType.G;

            this.Amperage = 13;

            this.Voltage = 230;

            this.ProngCount = 3;

            this.IsPolarized = true;
        }        
    }
}
