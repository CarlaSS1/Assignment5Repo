using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5.Plugs
{
    class TypeBPlug : Plug
    {
        public TypeBPlug()
        {
            this.Type = PlugType.B;

            this.Amperage = 15;

            this.Voltage = 120;

            this.ProngCount = 3;

            this.IsPolarized = true;

            this.IsConnected = false;
        }

        public override void Connect(Outlet outlet)
        {
            try
            {
                if (outlet.Type == OutletType.B)
                {
                    this.IsConnected = true;
                }
                else
                {
                    var adapter = new PlugAdapter();

                    var adaptedOutlet = adapter.Adapt<TypeBOutlet>(outlet);

                    this.Connect(adaptedOutlet);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override void Disconnect()
        {
            this.IsConnected = false;
        }
    }
}
