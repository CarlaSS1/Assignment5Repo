/*
 * I, Carla Sison, student number 000397812, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 3, 2019
 */

using System;
using System.Collections.Generic;
using System.Text;
using Problem2.Parts;

namespace Problem2
{
    /// <summary>
    /// Represents a builder of a computer
    /// </summary>
    public class ComputerBuilder : IComputer<Computer>
    {
        private readonly Computer computer;

        /// <summary>
        /// Initializes a new instance of <see cref="ComputerBuilder"/> class.
        /// </summary>
        public ComputerBuilder()
        {
            this.computer = new Computer();
        }

        public IComputer<Computer> AddCase(Case pcCase)
        {
            this.computer.PCCase = pcCase;
            return this;
        }

        public IComputer<Computer> AddMotherboard(IMotherboard<Motherboard> motherboard)
        {
            throw new NotImplementedException();
        }

        public Computer Build()
        {
            return this.computer;
        }

        // Inferace implementation

        public IComputer<Computer> SetPCName(string name)
        {
            this.computer.Name = name;
            return this;
        }

        
    }
}
