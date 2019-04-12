﻿using System;

namespace Problem5.Plugs
{
    /// <summary>
    /// Represents the typeA plug
    /// </summary>
    class TypeAPlug : Plug
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TypeAPlug"/> class.
        /// </summary>
        public TypeAPlug()
        {
            this.Type = PlugType.A;

            this.Amperage = 15;

            this.Voltage = 120;

            this.ProngCount = 2;

            this.IsPolarized = true;
        }

        /// <summary>
        /// Connects an outlet to type a plug
        /// </summary>
        /// <param name="outlet">The outlet</param>
        public override void Connect( Outlet outlet )
        {
            try
            {
                // Check if the outlet type is correct
                if (outlet.Type == OutletType.A)
                {
                    this.IsConnected = true;                    
                }
                else
                {
                    // Instantiate a new plug adapter for type a plug
                    var adapter = new PlugAdapter();

                    var adaptedOutlet = adapter.Adapt<TypeAOutlet>(outlet);

                    // Connect outlet to the adapter for type a plug.
                    this.Connect(adaptedOutlet);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Disconnects the outlet from type a plug
        /// </summary>
        public override void Disconnect()
        {
            this.IsConnected = false;
        }
    }
}
