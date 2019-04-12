using System;

namespace Problem5.Plugs
{
    /// <summary>
    /// Represents type d plug
    /// </summary>
    class TypeDPlug : Plug
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TypeDPlug"/> class.
        /// </summary>
        public TypeDPlug()
        {
            this.Type = PlugType.B;

            this.Amperage = 15;

            this.Voltage = 120;

            this.ProngCount = 3;

            this.IsPolarized = true;
        }

        /// <summary>
        /// Connects outlet to type d plug.
        /// </summary>
        /// <param name="outlet">The outlet.</param>
        public override void Connect(Outlet outlet)
        {
            try
            {
                // Check if the outlet type is correct.
                if (outlet.Type == OutletType.D)
                {
                    this.IsConnected = true;
                }
                else
                {
                    // Instantiate a plug adapter for type d for the outlet
                    var adapter = new PlugAdapter();

                    var adaptedOutlet = adapter.Adapt<TypeDOutlet>(outlet);

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
        /// Disconnects the outlet from type d plug.
        /// </summary>
        public override void Disconnect()
        {
            this.IsConnected = false;
        }
    }
}
