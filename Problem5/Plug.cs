/*
 * I, Steven Thompson, student number 000736020, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 11, 2019
 */

namespace Problem5
{
    /// <summary>
    /// Stores a list of plug types.
    /// </summary>
    public enum PlugType { A, B, C, D, G, H};

    /// <summary>
    /// Represents an abstract Plug class
    /// </summary>
    public abstract class Plug
    {
        /// <summary>
        /// Gets or sets the Plug Type
        /// </summary>
        /// <value>The Plug type</value>
        public PlugType Type { get; set; }

        /// <summary>
        /// Gets or sets the amperage
        /// </summary>
        /// <value>The amperage</value>
        public double Amperage { get; set; }

        /// <summary>
        /// Gets or sets the voltage
        /// </summary>
        /// <value>The Voltage</value>
        public int Voltage { get; set; }

        /// <summary>
        /// Gets or sets the prong count
        /// </summary>
        /// <value>The prong count</value>
        public int ProngCount { get; set; }

        /// <summary>
        /// Gets or sets the flag if the plug is polarized or not.
        /// </summary>
        /// <value>Flag for IsPolarized</value>
        public bool IsPolarized { get; set; }

        /// <summary>
        /// Gets or sets the flag for IsConnected
        /// </summary>
        /// <value>Flag for IsConnected</value>
        public bool IsConnected { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="Plug"/> class.
        /// </summary>
        public Plug(){}

        /// <summary>
        /// Connects the Outlet into the plug
        /// </summary>
        /// <param name="outlet">The outlet</param>
        public virtual void Connect(Outlet outlet)
        {
            
        }

        /// <summary>
        /// Disconnects the outlet from the plug
        /// </summary>
        public virtual void Disconnect()
        {
            
        }
    }
}
