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
    /// Represents a car that is a toy
    /// </summary>
    public class Car : Toy
    {
        // TO DO - Make 3 properties that describes the toy and have
        // 2 method which are actions that the toy can perform.

        /// <summary>
        /// Initializes a new instance of <see cref="Car"/> class.
        /// </summary>
        public Car()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Car"/> class.
        /// </summary>
        /// <param name="id">Global Unique ID</param>
        public Car(Guid id) : base(id)
        {
        }
        
        /// <summary>
        /// Initializes a new instance of <see cref="Car"/> class.
        /// </summary>
        /// <param name="id">Global Unique ID</param>
        /// <param name="cost">The cost.</param>
        /// <param name="description">The description.</param>
        /// <param name="name">The name.</param>
        /// <param name="manufacturingCompany">The manufacturing company.</param>
        /// <param name="year">The year.</param>
        /// <param name="ageLimitMax">Maximum age limit.</param>
        /// <param name="ageLimitMin">Minimum age limit.</param>
        /// <param name="weight">The weight.</param>
        /// <param name="isChokingHazard">Whether the toy is a choking hazard.</param>
        public Car(Guid id, double cost, string description, string name, string manufacturingCompany, int year, int ageLimitMax, int ageLimitMin, double weight, bool isChokingHazard) : base(id, cost, description, name, manufacturingCompany, year, ageLimitMax, ageLimitMin, weight, isChokingHazard)
        {
        }
    }
}
