/*
 * I, Riley Hancox, student number [studentid], certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 1, 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    /// <summary>
    /// Represents a rainbow stacker that is of a toy.
    /// </summary>
    public class RainbowStacker : Toy
    {
        // TO DO - Make 1 property that describes the toy and have
        // 2 method which are actions that the toy can perform.

        public int RingCount { get; set; }

        public string RingShape { get; set; }

        public RainbowStacker()
        {
        }

        public RainbowStacker(Guid id) : base(id)
        {
        }

        public RainbowStacker(Guid id, double cost, string description, string name, string manufacturingCompany, int year, int ageLimitMax, int ageLimitMin, double weight) : base(id, cost, description, name, manufacturingCompany, year, ageLimitMax, ageLimitMin, weight)
        {
        }
    }
}
