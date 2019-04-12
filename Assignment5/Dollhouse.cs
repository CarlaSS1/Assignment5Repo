/*
 * I, Riley Hancox, student number 000397119, certify that all code submitted is my own work; 
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
        /// <summary>
        /// Gets or sets the number of rooms.
        /// </summary>
        /// <value>The the number of rooms.</value>
        public int NumberOfRooms { get; set; }

        /// <summary>
        /// Gets or sets the number of floors.
        /// </summary>
        /// <value>The the number of floors.</value>
        public int NumberOfFloors { get; set; }

        /// <summary>
        /// Gets or sets the list of furniture.
        /// </summary>
        /// <value>The list of furniture.</value>
        public List<string> FurnitureCollection { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="Dollhouse"/> class.
        /// </summary>
        public Dollhouse()
        {
        }


        /// <summary>
        /// Initializes a new instance of <see cref="Dollhouse"/> class.
        /// </summary>
        /// <param name="id">Global Unique ID</param>
        public Dollhouse(Guid id) : base(id)
        {
        }

        /// <summary>
        /// Initalizes a new instance of <see cref="Dollhouse"/> class.
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
        public Dollhouse(Guid id, double cost, string description, string name, string manufacturingCompany, int year, int ageLimitMax, int ageLimitMin, double weight, bool isChokingHazard) : base(id, cost, description, name, manufacturingCompany, year, ageLimitMax, ageLimitMin, weight, isChokingHazard)
        {
        }

        /// <summary>
        /// Open the doll house.
        /// </summary>
        public void OpenDollHouse(){
            Console.WriteLine("The doll house is opened.");
        }        
        /// <summary>
        /// Close the doll house.
        /// </summary>
        public void CloseDollHouse(){
            Console.WriteLine("The doll house is closed.");
        }
    }
}
