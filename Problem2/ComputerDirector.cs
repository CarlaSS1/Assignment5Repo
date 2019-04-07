/*
 * I, Carla Sison, student number 000397812, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 7, 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Represents director of a computer
    /// </summary>
    public class ComputerDirector
    {
        /// <summary>
        /// Constructs a builder of type computer.
        /// </summary>
        /// <typeparam name="T">Type constraint of type computer</typeparam>
        /// <param name="builder">Builder from Computer Builder</param>
        /// <returns>A new computer</returns>
        public T Construct<T>(IComputer<T> builder) where T : Computer
        {
            return builder.Build();
        }
    }
}
