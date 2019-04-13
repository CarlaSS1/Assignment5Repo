/*
 * I, Steven Thompson, student number 000736020, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 11, 2019
 */

namespace Problem5.Plugs
{
    /// <summary>
    /// Represents a type b outlet.
    /// </summary>
    public class TypeBOutlet : Outlet
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TypeBOutlet"/> class.
        /// </summary>
        public TypeBOutlet()
        {
            this.Type = OutletType.B;

            this.Amperage = 15;

            this.Voltage = 120;

            this.ProngCount = 3;

            this.IsPolarized = true;
        }
        
    }
}
