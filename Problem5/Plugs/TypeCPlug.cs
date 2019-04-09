using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5.Plugs
{
    class TypeCPlug : Plug
    {
        public TypeCPlug()
        {
            this.Type = PlugType.C;

            this.Amperage = 2.5;

            this.Voltage = 250;

            this.ProngCount = 2;

            this.IsPolarized = true;
        }

        public override void Connect(Outlet outlet)
        {
            try
            {
                if (outlet.Type == OutletType.C)
                {
                    this.IsConnected = true;
                }
                else
                {
                    var adapter = new PlugAdapter();

                    var adaptedOutlet = adapter.Adapt<TypeCOutlet>(outlet);

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
