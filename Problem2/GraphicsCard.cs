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
    /// Represents a Graphics card.
    /// </summary>
    public class GraphicsCard
    {
        public string Name { get; set; }

        public int FanCount { get; set; }

        public double Speed { get; set; }

        public double VideoMemory { get; set; }

        public int CUDACores { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="GraphicsCard"/> class.
        /// </summary>
        public GraphicsCard() {}
        
        /// <summary>
        /// Initializes a new instance of <see cref="GraphicsCard"/> class.
        /// </summary>
        /// <param name="name">Graphics Card name</param>
        /// <param name="fanCount">The fan count.</param>
        /// <param name="speed">The speed.</param>
        /// <param name="videoMemory">The video memory.</param>
        /// <param name="cUDACores">The CUDA cores</param>
        public GraphicsCard(string name, int fanCount, double speed, double videoMemory, int cUDACores)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            FanCount = fanCount;
            Speed = speed;
            VideoMemory = videoMemory;
            CUDACores = cUDACores;
        }
    }
}

// It is assumed that the graphics card are in GB.
// Conversion is done to present the correct content as needed.