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
    /// Represets a plug adapater that inherits from outlet
    /// </summary>
    class PlugAdapter : Outlet
    {
        /// <summary>
        /// Outlet that is derived from outlet class.
        /// </summary>
        protected Outlet Outlet;

        /// <summary>
        /// Initializes a new instance of <see cref="PlugAdapter"/> class.
        /// </summary>
        public PlugAdapter() {}

        /// <summary>
        /// Returns an adapted of type Outlet
        /// </summary>
        /// <typeparam name="T">Type contranted to Outlet</typeparam>
        /// <param name="outlet">The outlet</param>
        /// <returns>Adapated outlet</returns>
        public T Adapt<T>(Outlet outlet) where T : Outlet
        {
            return (T)Adapt( outlet );
        }
        
        /// <summary>
        /// Tranverse expression tree to check for adapter type of an outlet
        /// </summary>
        /// <param name="outlet">The outlet</param>
        /// <returns>A instance of type for an outlet.</returns>
        public object Adapt( Outlet outlet )
        {
            switch ( outlet )
            {
                case TypeAOutlet a:

                    this.Outlet = new TypeAOutlet();

                    break;
                case TypeBOutlet b:

                    this.Outlet = new TypeBOutlet();

                    break;
                case TypeCOutlet c:

                    this.Outlet = new TypeCOutlet();

                    break;
                case TypeDOutlet d:

                    this.Outlet = new TypeDOutlet();

                    break;
                case TypeGOutlet g:

                    this.Outlet = new TypeGOutlet();

                    break;
                case TypeHOutlet h:

                    this.Outlet = new TypeHOutlet();

                    break;
                default:
                    throw new Exception("There is no existing outlet that this plug can be adapted to, please try a valid plug type.");
                 
            }

            return this.Outlet;
        }
    }
}