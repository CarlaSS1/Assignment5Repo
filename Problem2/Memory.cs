/*
 * I, Carla Sison, student number 000397812, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 1, 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2
{
    /// <summary>
    /// Stores a list of all available Memory types
    /// </summary>
    public enum MemoryType { DDR1, DDR2, DDR3, DDR4 };

    /// <summary>
    /// Represents a memory from a motherboard.
    /// </summary>
    public class Memory
    {
        public int ReadSpeed { get; set; }

        public int WriteSpeed { get; set; }

        public MemoryType TypeMemory { get; set; }

        public double Capacity { get; set; }

        public Memory() {}

        public Memory(int readSpeed, int writeSpeed, MemoryType typeMemory, double capacity)
        {
            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
            TypeMemory = typeMemory;
            Capacity = capacity;
        }
    }
}
