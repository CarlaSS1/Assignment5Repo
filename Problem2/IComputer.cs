/*
 * I, Carla Sison, student number 000397812, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 5, 2019
 */

namespace Problem2
{
    /// <summary>
    /// Represents an interface for a Computer.
    /// </summary>
    public interface IComputer<out T> where T : Computer
    {
        // Computer has a case.

        /// <summary>
        /// Support the addition of a PC case for a computer
        /// </summary>
        /// <param name="pcCase">The pc case</param>
        /// <returns>Computer with a PC case</returns>
        IComputer<T> AddCase(Case pcCase);

        /// <summary>
        /// Adds a new mother board to the computer
        /// </summary>
        /// <param name="motherboard">The motherboard</param>
        /// <returns>A computer with a motherboard</returns>
        IComputer<T> AddMotherboard(Motherboard motherboard);

        /// <summary>
        /// Builds a new computer object
        /// </summary>
        /// <returns>A new computer object</returns>
        T Build();

        // sets - Might have to make another interface, oh my god. WHy.

        /// <summary>
        /// Sets the name of a PC
        /// </summary>
        /// <param name="name">The name</param>
        /// <returns>A computer with a new name</returns>
        IComputer<T> SetPCName(string name);
    }
}

// Complex Object for an interface
// If it is solid data, don't make an interface