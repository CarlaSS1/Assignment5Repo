using System;

namespace Problem5.Plugs
{
    /// <summary>
    /// Represents a type c plug
    /// </summary>
    class TypeCPlug : Plug
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TypeCPlug"/> class.
        /// </summary>
        public TypeCPlug()
        {
            this.Type = PlugType.C;

            this.Amperage = 2.5;

            this.Voltage = 250;

            this.ProngCount = 2;

            this.IsPolarized = true;
        }

        /// <summary>
        /// Connects outlet to type c plug.
        /// </summary>
        /// <param name="outlet">The outlet</param>
        public override void Connect(Outlet outlet)
        {
            try
            {
                // Check if the outlet type is correct
                if (outlet.Type == OutletType.C)
                {
                    this.IsConnected = true;
                }
                else
                {
                    // Instantiate a plug adapter of type c for the outlet
                    var adapter = new PlugAdapter();

                    var adaptedOutlet = adapter.Adapt<TypeCOutlet>(outlet);

                    // Connect the outlet to the adapter
                    this.Connect(adaptedOutlet);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Disconnects the outlet from type c plug.
        /// </summary>
        public override void Disconnect()
        {
            this.IsConnected = false;
        }
    }
}
