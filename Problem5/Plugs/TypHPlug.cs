/*
 * I, Steven Thompson, student number 000736020, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 11, 2019
 */

using System;

namespace Problem5.Plugs
{
    /// <summary>
    /// Represents a type h plug.
    /// </summary>
    class TypeHPlug : Plug
    {
        /// <summary>
        /// Initinalizes a new instance of <see cref="TypeHPlug"/> class.
        /// </summary>
        public TypeHPlug()
        {
            this.Type = PlugType.H;

            this.Amperage = 16;

            this.Voltage = 250;

            this.ProngCount = 3;

            this.IsPolarized = true;
        }

        /// <summary>
        /// Connects outlet to type h plug
        /// </summary>
        /// <param name="outlet">The outlet.</param>
        public override void Connect(Outlet outlet)
        {
            try
            {
                // Check if the outlet type is correct
                if (outlet.Type == OutletType.H)
                {
                    this.IsConnected = true;
                }
                else
                {
                    // Instantiate a plug adapter of type h for the outlet.
                    var adapter = new PlugAdapter();

                    var adaptedOutlet = adapter.Adapt<TypeHOutlet>(outlet);

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
        /// Disconnects outlet from type h plug.
        /// </summary>
        public override void Disconnect()
        {
            this.IsConnected = false;
        }
    }
}
