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
    /// Stores a list of manufacturers
    /// </summary>
    public enum CpuManufacturer { Intel, AMD };

    /// <summary>
    /// Stores a list of Socket types.
    /// </summary>
    /// <remarks>I won't anything old like a Dip socket type</remarks>
    public enum CpuSocketTypes{ LGA, PGA, BGA };

    /// <summary>
    /// Represents the CPU.
    /// </summary>
    public class Cpu
    {
        /// <summary>
        /// Gets or sets the name of a cpu.
        /// </summary>
        /// <value>Cpu name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the CPU speed
        /// </summary>
        /// <value>Cpu Speed.</value>
        public double Speed { get; set; }

        /// <summary>
        /// Gets or sets Manufacturer
        /// </summary>
        /// <value>CPU Manufacturer</value>
        public CpuManufacturer Manufacturer { get; }

        /// <summary>
        /// Gets the SocketType
        /// </summary>
        /// <value>The Socket type for a Cpu.</value>
        public CpuSocketTypes SocketType { get; }

        /// <summary>
        /// Gets or sets Cache size
        /// </summary>
        /// <value>The cache size.</value>
        public int CacheSize { get; set; }

        /// <summary>
        /// Gets or sets the number of cores
        /// </summary>
        /// <value>The number of cores.</value>
        public int NumberOfCores { get; set; }


        /// <summary>
        /// Initializes a new instance of <see cref="Cpu"/> class.
        /// </summary>
        public Cpu() {}

        /// <summary>
        /// Initializes a new instance of <see cref="Cpu"/> class.
        /// </summary>
        /// <param name="name">Cpu Name.</param>
        /// <param name="speed">Cpu Speed.</param>
        /// <param name="manufacturer">Cpu Manufacturer</param>
        /// <param name="socketType">The Socket type</param>
        /// <param name="cacheSize">The Cache Size.</param>
        /// <param name="numberOfCores">The number of cores.</param>
        public Cpu(string name, double speed, CpuManufacturer manufacturer, CpuSocketTypes socketType, int cacheSize, int numberOfCores)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Speed = speed;
            Manufacturer = manufacturer;
            SocketType = socketType;
            CacheSize = cacheSize;
            NumberOfCores = numberOfCores;
        }
    }
}

// For the sake of argument, we will be assuming MB Cache size.
// Composition: If the parents class dies, then the classes that uses it will no longer be of use.
// Think of a car without an engine. It can't work without an engine.

// For CPU socket types, I just used this a frame of reference: https://www.makeuseof.com/tag/cpu-socket-types-explained-from-socket-5-to-bga-makeuseof-explains/
