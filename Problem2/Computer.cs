/*
 * I, Carla Sison, student number 000397812, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 1, 2019
 */

using System;

namespace Problem2
{
    /// <summary>
    /// Represents an abstract Computer
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// Gets or sets a global unique identifier.
        /// </summary>
        /// <value>The global unique identifier.</value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets the motherboard
        /// </summary>
        /// <value>The Motherboard</value>
        public Motherboard GetMotherboard { get; }

        /// <summary>
        /// Gets the case
        /// </summary>
        /// <value>The case</value>
        public Case PCCase { get; }

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
