using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5.Plugs
{
    class TypeGPlug : Plug
    {
        public TypeGPlug()
        {
            this.Type = PlugType.G;

            this.Amperage = 13;

            this.Voltage = 230;

            this.ProngCount = 3;

            this.IsPolarized = true;
        }

        public override void Connect(Outlet outlet)
        {
            try
            {
                if (outlet.Type == OutletType.G)
                {
                    this.IsConnected = true;
                }
                else
                {
                    var adapter = new PlugAdapter();

                    var adaptedOutlet = adapter.Adapt<TypeGOutlet>(outlet);

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
