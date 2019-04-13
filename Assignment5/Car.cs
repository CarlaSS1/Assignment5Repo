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
    /// Represents a car that is a toy
    /// </summary>
    public class Car : Toy
    {      
        
        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>The model of the toy car.</value>
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the make.
        /// </summary>
        /// <value>The make of the toy car.</value>
        public string Make { get; set; }

        /// <summary>
        /// Gets or sets the number of wheels.
        /// </summary>
        /// <value>The number of wheels of the toy car.</value>
        public int? NumberOfWheels { get; set; }
   
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
        public Car(Guid id, double cost, string description, string name, string manufacturingCompany, int year, int ageLimitMax, int ageLimitMin, double weight, bool isChokingHazard, string model = null, string make =null, int? wheels = null) : base(id, cost, description, name, manufacturingCompany, year, ageLimitMax, ageLimitMin, weight, isChokingHazard)
        {
            Model = model;
            Make = make;
            NumberOfWheels = wheels;
                 
        }

        /// <summary>
        /// Race the toy car.
        /// </summary>
        public void RaceToyCar(){
            Console.WriteLine("The toy car has been raced.");

        }
        /// <summary>
        /// Open the toy car door.
        /// </summary>
        public void OpenToyCarDoor(){
            Console.WriteLine("The toy car door has been opened.");

        }
    }
}
