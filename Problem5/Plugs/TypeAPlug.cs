using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5.Plugs
{
    class TypeAPlug : Plug
    {
        public TypeAPlug()
        {
            this.Type = PlugType.A;

            this.Amperage = 15;

            this.Voltage = 120;

            this.ProngCount = 2;

            this.IsPolarized = true;
        }

        public override void Connect( Outlet outlet )
        {
            try
            {

                if (outlet.Type == OutletType.A)
                {
                    this.IsConnected = true;                    
                }
                else
                {
                    var adapter = new PlugAdapter();

                    var adaptedOutlet = adapter.Adapt<TypeAOutlet>(outlet);

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
