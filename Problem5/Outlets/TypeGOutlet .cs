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
    /// Represent a type g outlet.
    /// </summary>
    class TypeGOutlet : Outlet
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TypeGOutlet"/> class.
        /// </summary>
        public TypeGOutlet()
        {
            this.Type = OutletType.G;

            this.Amperage = 13;

            this.Voltage = 230;

            this.ProngCount = 3;

            this.IsPolarized = true;
        }        
    }
}
