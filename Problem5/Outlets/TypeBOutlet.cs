using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5.Plugs
{
    class TypeBOutlet : Outlet
    {
        public TypeBOutlet()
        {
            this.Type = OutletType.B;

            this.Amperage = 15;

            this.Voltage = 120;

            this.ProngCount = 3;

            this.IsPolarized = true;
        }
        
    }
}
