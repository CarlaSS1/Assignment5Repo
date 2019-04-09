using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5.Plugs
{
    class TypeHOutlet : Outlet
    {
        public TypeHOutlet()
        {
            this.Type = OutletType.H;

            this.Amperage = 16;

            this.Voltage = 250;

            this.ProngCount = 3;

            this.IsPolarized = true;
        }
        
    }
}
