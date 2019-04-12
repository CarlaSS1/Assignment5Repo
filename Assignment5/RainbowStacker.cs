/*
 * I, Riley Hancox, student number 000397119, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 1, 2019
 */

using System;
using System.Collections.Generic;

namespace Assignment5
{
    /// <summary>
    /// Represents a rainbow stacker that is of a toy.
    /// </summary>
    public class RainbowStacker : Toy
    {

        /// <summary>
        /// Gets or sets the ring count
        /// </summary>
        /// <value>The ring count</value>
        public int RingCount { get; set; }

        /// <summary>
        /// Gets or sets the ring shape.
        /// </summary>
        /// <value>The ring shape.</value>
        public string RingShape { get; set; }

        /// <summary>
        /// Gets or sets the list of the ring colours.
        /// </summary>
        /// <value>The list of the ring colours.</value>
        public List<string> RingColourCollection { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="RainbowStacker"/> class.
        /// </summary>
        public RainbowStacker()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="RainbowStacker"/> class.
        /// </summary>
        /// <param name="id">Global Unique ID.</param>
        public RainbowStacker(Guid id) : base(id)
        {
        }

        /// <summary>
        /// Initalizes a new instance of <see cref="RainbowStacker"/> class.
        /// </summary>
        /// <param name="id">Global Unique ID.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="description">The description.</param>
        /// <param name="name">The name.</param>
        /// <param name="manufacturingCompany">The manufacturing company.</param>
        /// <param name="year">The year.</param>
        /// <param name="ageLimitMax">Maximum age limit.</param>
        /// <param name="ageLimitMin">Minimum age limit.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="isChokingHazard">Whether the toy is a choking hazard.</param>
        public RainbowStacker(Guid id, double cost, string description, string name, string manufacturingCompany, int year, int ageLimitMax, int ageLimitMin, double weight, bool isChokingHazard) : base(id, cost, description, name, manufacturingCompany, year, ageLimitMax, ageLimitMin, weight, isChokingHazard)
        {
        }

        /// <summary>
        /// Stack the rings.
        /// </summary>
        public void StackRings(){
            Console.WriteLine("The rings have been stacked.");
            }

        /// <summary>
        /// Unstack the rings.
        /// </summary>
        public void UnstackRings(){
            Console.WriteLine("The rings have been unstacked.");
            }
    }
}
