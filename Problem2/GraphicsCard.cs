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
        public int FanCount { get; set; }

        public int Speed { get; set; }

        public double VideoMemory { get; set; }

        public int CUDACores { get; set; }

        public GraphicsCard() {}

        public GraphicsCard(int fanCount, int speed, double videoMemory, int cUDACores)
        {
            FanCount = fanCount;
            Speed = speed;
            VideoMemory = videoMemory;
            CUDACores = cUDACores;
        }
    }
}

// It is assumed that the graphics card are in GB.
// Conversion is done to present the correct content as needed.