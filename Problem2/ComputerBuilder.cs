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

        public Motherboard Board { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="ComputerBuilder"/> class.
        /// </summary>
        public ComputerBuilder()
        {
            this.computer = new Computer();
        }

        /// <summary>
        /// Builds the computer.
        /// </summary>
        /// <returns></returns>
        public Computer Build()
        {
            return this.computer;
        }

        public IComputer<Computer> AddHardDrive(int count)
        {
            throw new NotImplementedException();
        }

        public IComputer<Computer> SetHardDrive(int count)
        {
            throw new NotImplementedException();
        }

        public IComputer<Computer> AddMotherBoard(Motherboard board)
        {
            if(this.computer.Board == null)
            {
                // Disposes the original contents of the motherboard.
                this.Board.Dispose();
            }

            this.computer.Board = board;
            return this;
        }

        public IComputer<Computer> AddCase(int count)
        {
            throw new NotImplementedException();
        }

        public IComputer<Computer> SetCase(int count)
        {
            throw new NotImplementedException();
        }

        public IComputer<Computer> SetMotherBoard(int count)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Verifys that the Cpu speed is valid
        /// </summary>
        /// <param name="speed"></param>
        /// <returns></returns>
        public IComputer<Computer> SetCpuSpeed(double speed)
        {
            throw new NotImplementedException();
        }


        // TO DO - Verify parts.


        // TO DO - Revisit the Builder example from the slides and notes.
    }
}

