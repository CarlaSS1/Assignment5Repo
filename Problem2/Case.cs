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
    /// Represents a case for a computer
    /// </summary>
    public class Case
    {
        /// <summary>
        /// Gets or sets a case length
        /// </summary>
        /// <value>The width of a case.</value>
        public double Length { get; set; }

        public double Width { get; set; }

        public double Height { get; set; }

        public int Fans { get; set; }

        public int Vents { get; set; }

        public Case() {}

        public Case(double length, double width, double height, int fans, int vents)
        {
            Length = length;
            Width = width;
            Height = height;
            Fans = fans;
            Vents = vents;
        }
    }
}
