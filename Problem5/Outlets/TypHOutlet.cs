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
    /// Represents a type h outlet
    /// </summary>
    class TypeHOutlet : Outlet
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TypeHOutlet"/> class.
        /// </summary>
        public TypeHOutlet()
        {
            this.Type = OutletType.H;

            this.Amperage = 16;

            this.Voltage = 250;

            this.ProngCount = 3;

            this.IsPolarized = true;
        }
        
    }
}
