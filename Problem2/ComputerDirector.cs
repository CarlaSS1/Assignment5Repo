/*
 * I, Carla Sison, student number 000397812, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 11, 2019
 */

namespace Problem2
{
    /// <summary>
    /// Represents Computer Director class.
    /// </summary>
    public class ComputerDirector
    {
        /// <summary>
        /// Assembles the Computer from the builder/
        /// </summary>
        /// <typeparam name="T">Constructs builder of type computer</typeparam>
        /// <param name="builder">The builder</param>
        /// <returns>A computer.</returns>
        public T Construct<T>(IComputer<T> builder) where T : Computer
        {
            return builder.Build();
        }
    }
}
