using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5.Plugs
{
    class TypeHPlug : Plug
    {
        public TypeHPlug()
        {
            this.Type = PlugType.H;

            this.Amperage = 16;

            this.Voltage = 250;

            this.ProngCount = 3;

            this.IsPolarized = true;
        }

        public override void Connect(Outlet outlet)
        {
            try
            {
                if (outlet.Type == OutletType.H)
                {
                    this.IsConnected = true;
                }
                else
                {
                    var adapter = new PlugAdapter();

                    var adaptedOutlet = adapter.Adapt<TypeHOutlet>(outlet);

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
