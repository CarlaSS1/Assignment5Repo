using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5.Plugs
{
    class TypeDOutlet : Outlet
    {
        public TypeDOutlet()
        {
            this.Type = OutletType.D;

            this.Amperage = 5;

            this.Voltage = 250;

            this.ProngCount = 3;

            this.IsPolarized = true;
        }
        
    }
}
