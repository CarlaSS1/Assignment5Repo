using System;

namespace Problem5.Plugs
{
    /// <summary>
    /// Represents type b plug
    /// </summary>
    class TypeBPlug : Plug
    {
        /// <summary>
        /// Initinalizes a new instance of <see cref="TypeBPlug"/> class.
        /// </summary>
        public TypeBPlug()
        {
            this.Type = PlugType.B;

            this.Amperage = 15;

            this.Voltage = 120;

            this.ProngCount = 3;

            this.IsPolarized = true;

            this.IsConnected = false;
        }

        /// <summary>
        /// Connects outlet to type b plug.
        /// </summary>
        /// <param name="outlet">The outlet</param>
        public override void Connect(Outlet outlet)
        {
            try
            {
                // Check if the outlet type is correct
                if (outlet.Type == OutletType.B)
                {
                    this.IsConnected = true;
                }
                else
                {
                    // Instantiate a plug adapater of type b for the outlet
                    var adapter = new PlugAdapter();

                    var adaptedOutlet = adapter.Adapt<TypeBOutlet>(outlet);

                    // Connect the outlet to the adapter.
                    this.Connect(adaptedOutlet);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Disconnects outlet from type b plug
        /// </summary>
        public override void Disconnect()
        {
            this.IsConnected = false;
        }
    }
}
