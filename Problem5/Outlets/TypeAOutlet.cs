using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5.Plugs
{
    class TypeAOutlet : Outlet
    {
        public TypeAOutlet()
        {
            this.Type = OutletType.A;

            this.Amperage = 15;

            this.Voltage = 120;

            this.ProngCount = 2;

            this.IsPolarized = true;
        }
        
    }
}
