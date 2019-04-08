using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5.Plugs
{
    class TypeCOutlet : Outlet
    {
        public TypeCOutlet()
        {
            this.Type = OutletType.C;

            this.Amperage = 2.5;

            this.Voltage = 250;

            this.ProngCount = 2;

            this.IsPolarized = true;
        }
        
    }
}
