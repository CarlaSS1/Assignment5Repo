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
    /// Represents a Toy
    /// </summary>
    public abstract class Toy
    {
        /// <summary>
        /// Gets or sets a global unique ID
        /// </summary>
        /// <value>Global Unique ID.</value>
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the cost.
        /// </summary>
        /// <value>The cost.</value>
        public double Cost { get; set; }

        /// <summary>
        /// Gets or sets Description
        /// </summary>
        /// <value>The description</value>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets Name
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the Manufacturing company
        /// </summary>
        /// <value>The manufacturing company.</value>
        public string ManufacturingCompany { get; set; }
        
        /// <summary>
        /// Gets or sets a year.
        /// </summary>
        /// <value>The year.</value>
        public int Year { get; set; }

        /// <summary>
        /// Gets or sets the maximun age limit.
        /// </summary>
        /// <value>The maximum age limit.</value>
        public int AgeLimitMaximum  { get; set; }

        /// <summary>
        /// Gets or sets the minimum age limit.
        /// </summary>
        /// <value>The minimum age limit</value>
        public int AgeLimitMinimum  { get; set; }

        /// <summary>
        /// Gets or sets is choking hazard.
        /// </summary>
        /// <value>Whether the toy is a choking hazard./</value>
        public bool IsChokingHazard {get;set;}

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>The weight.</value>
        public double Weight { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="Toy"/> class.
        /// </summary>
        /// <param name="id">Global Unique ID.</param>
        protected Toy(Guid id)
        {
            Id = id;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Toy"/> class.
        /// </summary>
        public Toy() {}


        /// <summary>
        /// Initializes a new instance of <see cref="Toy"/> class.
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
        public Toy(Guid id, double cost, string description, string name, string manufacturingCompany, int year, int ageLimitMax, int ageLimitMin, double weight, bool isChokingHazard) : this(id)
        {
            Cost = cost;
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            ManufacturingCompany = manufacturingCompany ?? throw new ArgumentNullException(nameof(manufacturingCompany));
            Year = year;
            AgeLimitMaximum = ageLimitMax;
            AgeLimitMinimum = ageLimitMin;
            Weight = weight;
            IsChokingHazard = IsChokingHazard;
        }
    }
}
