﻿/*
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
    public abstract class Computer
    {
        public Guid Id { get; set; }

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
