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
    /// Stores a list of Outlet Type.
    /// </summary>
    public enum OutletType { A, B, C, D, G, H };

    /// <summary>
    /// Represents an abstract outlet class.
    /// </summary>
    public abstract class Outlet
    {
        /// <summary>
        /// Gets or sets an outlet type
        /// </summary>
        /// <value>The outlet type</value>
        public OutletType Type { get; set; }

        /// <summary>
        /// Gets or sets the amperage
        /// </summary>
        /// <value>The Amperage</value>
        public double Amperage { get; set; }

        /// <summary>
        /// Gets or sets the voltage
        /// </summary>
        /// <value>The voltage</value>
        public int Voltage { get; set; }

        /// <summary>
        /// Gets or sets the prong count
        /// </summary>
        /// <value>The prong count</value>
        public int ProngCount { get; set; }

        /// <summary>
        /// Gets or sets flag IsPolarized
        /// </summary>
        /// <value>IsPolarized flag</value>
        public bool IsPolarized { get; set; }
        
        /// <summary>
        /// Initializes a new instance of <see cref="Outlet"/> class.
        /// </summary>
        public Outlet() { }
                
    }
}
