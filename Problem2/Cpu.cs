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
    /// Stores a list of manufacturers
    /// </summary>
    public enum CpuManufacturer { Intel, AMD };

    /// <summary>
    /// Represents the CPU.
    /// </summary>
    public class Cpu
    {
        public double Speed { get; set; }

        public CpuManufacturer Manufacturer { get; set; }

        // Look up specific conditions as to what defines as a Socket Type
        public string SocketType { get; set; }

        public int CacheSize { get; set; }

        public int NumberOfCores { get; set; }

        public Cpu() {}

        public Cpu(double speed, CpuManufacturer manufacturer, string socketType, int cacheSize, int numberOfCores)
        {
            Speed = speed;
            Manufacturer = manufacturer;
            SocketType = socketType ?? throw new ArgumentNullException(nameof(socketType));
            CacheSize = cacheSize;
            NumberOfCores = numberOfCores;
        }
    }
}

// For the sake of argument, we will be assuming MB Cache size.
