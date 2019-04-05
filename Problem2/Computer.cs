/*
 * I, Carla Sison, student number 000397812, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 1, 2019
 */

using System;
using System.Collections.Generic;

namespace Problem2
{
    /// <summary>
    /// Represents an abstract Computer
    /// </summary>
    public abstract class Computer
    {
        /// <summary>
        /// Gets or sets a global unique identifier.
        /// </summary>
        /// <value>The global unique identifier.</value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets a Motherboard.
        /// </summary>
        /// <value>A mother board.</value>
        public Motherboard Board { get; }

        /// <summary>
        /// Gets a case
        /// </summary>
        /// <value>A Computer case</value>
        public Case Case { get; }

        // TO DO - Deciding what should be in this class.


        /// <summary>
        /// Initializes a new instance of <see cref="Computer"/> class.
        /// </summary>
        public Computer() { }

        /// <summary>
        /// Initializes a new instance of <see cref="Computer"/> class.
        /// </summary>
        /// <param name="id">Global Unique ID</param>
        protected  Computer(Guid id)
        {
            Id = id;
        }

        // What's a computer.

    }
}

// Computer has a:
// has 1 Mother Board
//      Motherboard has 1 CPU
// Has 1 to many hard drives
// has 1 to many memory
// has 1 case
// has 1 CPU

// Uses the Builder Pattern.
// Look over Assignment 2 for your example.
// PC cannot go with out a Motherboard
// PC cannot go without a hard drive.
// PC can go without a case.

// Mother board usually has 2 - 4 memory slots