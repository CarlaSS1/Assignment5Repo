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
    /// Represents a doll house that is of a toy.
    /// </summary>
    public class Dollhouse : Toy
    {
        // TO DO - Make 3 properties that describes the toy and have
        // 2 method which are actions that the toy can perform.

        public Dollhouse()
        {
        }

        public Dollhouse(Guid id) : base(id)
        {
        }

        public Dollhouse(Guid id, double cost, string description, string name, string manufacturingCompany, int year, int ageLimitMax, int ageLimitMin, double weight) : base(id, cost, description, name, manufacturingCompany, year, ageLimitMax, ageLimitMin, weight)
        {
        }
    }
}
