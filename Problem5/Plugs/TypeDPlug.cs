using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5.Plugs
{
    class TypeDPlug : Plug
    {
        public TypeDPlug()
        {
            this.Type = PlugType.B;

            this.Amperage = 15;

            this.Voltage = 120;

            this.ProngCount = 3;

            this.IsPolarized = true;
        }

        public override void Connect(Outlet outlet)
        {
            try
            {
                if (outlet.Type == OutletType.D)
                {
                    this.IsConnected = true;
                }
                else
                {
                    var adapter = new PlugAdapter();

                    var adaptedOutlet = adapter.Adapt<TypeDOutlet>(outlet);

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
