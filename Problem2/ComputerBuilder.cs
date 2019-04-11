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

        public IComputer<Computer> AddCase()
        {
            Case @case = new Case();

            this.computer.PCCase = @case;
            return null;
        }

        public IComputer<Computer> AddHardDrive(HardDrive hardDrive)
        {
            // Would this go against the law of demeter?
            if(this.computer.GetMotherboard.HardDriveLimit != 0)
            {
                
            }

            return null;
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

        // Validation Methods - Unique to the Computer Builder

        public bool VerifyCpuSpeed<T>(double speed) where T : Cpu
        {
            if(speed <= 0)
            {
                // TO DO - Create an error message or something.
            } 

            return false;
        }

        
    }
}
