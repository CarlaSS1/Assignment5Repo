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
        /// <value>The length of a case.</value>
        public double Length { get; set; }

        /// <summary>
        /// Gets or sets a width of a case
        /// </summary>
        /// <value>The width.</value>
        public double Width { get; set; }

        /// <summary>
        /// Gets or sets a height of a case.
        /// </summary>
        /// <value>The height.</value>
        public double Height { get; set; }

        /// <summary>
        /// Gets or sets the number of fans from a case.
        /// </summary>
        /// <value>The fans.</value>
        public int Fans { get; set; }

        /// <summary>
        /// Gets or sets the number of vents from a case.
        /// </summary>
        /// <value>The Vents.</value>
        public int Vents { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="Case"/> class.
        /// </summary>
        public Case() {}

        /// <summary>
        /// Initializes a new instance of <see cref="Case"/> class
        /// </summary>
        /// <param name="length">The length.</param>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="fans">The fans.</param>
        /// <param name="vents">The vents.</param>
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
