/*
 * I, Riley Hancox, student number 000397119, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 1, 2019
 */

using System;

namespace Assignment5
{
    /// <summary>
    /// Represents a Stuffed animal that is a toy
    /// </summary>
    public class StuffedAnimal : Toy
    {
        /// <summary>
        /// Gets or sets the animal type.
        /// </summary>
        /// <value>The animal type.</value>
        public string AnimalType {get; set;}

        /// <summary>
        /// Gets or sets the stuffing type.
        /// </summary>
        /// <value>The stuffing type.</value>
        public string StuffingType {get; set;}

        /// <summary>
        /// Gets or sets the stitching type.
        /// </summary>
        /// <value>The stitching type.</value>
        public string StitchingType {get; set;}
       
        /// <summary>
        /// Initializes a new instance of <see cref="StuffedAnimal"/> class.
        /// </summary>
        public StuffedAnimal()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="StuffedAnimal"/> class.
        /// </summary>
        /// <param name="id">Global Unique ID.</param>
        public StuffedAnimal(Guid id) : base(id)
        {
        }

        /// <summary>
        /// Initalizes a new instance of <see cref="StuffedAnimal"/> class.
        /// </summary>
        /// <param name="id">Global Unique ID.</param>
        /// <param name="cost">The cost.</param>
        /// <param name="description">The description.</param>
        /// <param name="name">The name.</param>
        /// <param name="manufacturingCompany">The manufacturing company.</param>
        /// <param name="year">The year.</param>
        /// <param name="ageLimitMax">Maximum age limit.</param>
        /// <param name="ageLimitMin">Minimum age limit.</param>
        /// <param name="weight">The weight</param>
        /// <param name="isChokingHazard">Whether the toy is a choking hazard.</param>
        public StuffedAnimal(Guid id, double cost, string description, string name, string manufacturingCompany, int year, int ageLimitMax, int ageLimitMin, double weight, bool isChokingHazard, string animalType = null, string stuffingType = null, string stitchingType = null) : base(id, cost, description, name, manufacturingCompany, year, ageLimitMax, ageLimitMin, weight, isChokingHazard)
        {
            StitchingType = stitchingType;
            AnimalType = animalType;
            StuffingType = stuffingType;
        }

        /// <summary>
        /// Attend a tea party.
        /// </summary>
        public void AttendTeaParty(){
            Console.WriteLine("The stuffed animal attended a tea party.");
        }

        /// <summary>
        /// Sleep in a bed.
        /// </summary>
        public void SleepInBed(){
            Console.WriteLine("The stuffed animal slept in bed");
        }
    }
}
