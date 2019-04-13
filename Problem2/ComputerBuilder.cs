/*
 * I, Carla Sison, student number 000397812, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 3, 2019
 */

using Problem2.Parts;

namespace Problem2
{
    /// <summary>
    /// Represents a builder of a computer
    /// </summary>
    public class ComputerBuilder : IComputer<Computer>
    {
        // Maintians the current computer object
        private readonly Computer computer;

        // Maintains the motherboard object
        public IMotherboard<Motherboard> motherboard;

        /// <summary>
        /// Initializes a new instance of <see cref="ComputerBuilder"/> class.
        /// </summary>
        public ComputerBuilder()
        {
            this.computer = new Computer();
        }

        /// <summary>
        /// Adds a new PC case to the computer
        /// </summary>
        /// <param name="pcCase">The PC case.</param>
        /// <returns>Computer with a new pc case</returns>
        public IComputer<Computer> AddCase(Case pcCase)
        {
            this.computer.PCCase = pcCase;
            return this;
        }

        /// <summary>
        /// Adds a new motherboard to the computer
        /// </summary>
        /// <param name="motherboard">The motherboard</param>
        /// <returns>Computer with a new motherboard</returns>
        public IComputer<Computer> AddMotherboard(Motherboard motherboard)
        {
            var board = this.motherboard;

            board = (IMotherboard<Motherboard>)motherboard;
            
            this.computer.Board = this.motherboard.Build();
            return this;
        }

        /// <summary>
        /// Builds the new Computer object
        /// </summary>
        /// <returns>A computer</returns>
        public Computer Build()
        {
            return this.computer;
        }

        // Inferace implementation

        /// <summary>
        /// Sets a name of the PC
        /// </summary>
        /// <param name="name">The name</param>
        /// <returns>Computer with a name.</returns>
        public IComputer<Computer> SetPCName(string name)
        {
            this.computer.Name = name;
            return this;
        }
    }
}
