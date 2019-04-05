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

        }

        public Computer Build()
        {
            throw new NotImplementedException();
        }



        // TO DO - Revisit the Builder example from the slides and notes.

    }
}
