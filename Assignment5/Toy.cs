/*
 * I, Riley Hancox, student number [studentid], certify that all code submitted is my own work; 
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
        public Guid Id { get; set; }

        public double Cost { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string ManufacturingCompany { get; set; }

        public int Year { get; set; }

        public int AgeLimitMax { get; set; }

        public int AgeLimitMin { get; set; }

        // Choking Hazard - Enum List or a Enum?

        public double Weight { get; set; }

        protected Toy(Guid id)
        {
            Id = id;
        }

        public Toy() {}

        public Toy(Guid id, double cost, string description, string name, string manufacturingCompany, int year, int ageLimitMax, int ageLimitMin, double weight) : this(id)
        {
            Cost = cost;
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Name = name ?? throw new ArgumentNullException(nameof(name));
            ManufacturingCompany = manufacturingCompany ?? throw new ArgumentNullException(nameof(manufacturingCompany));
            Year = year;
            AgeLimitMax = ageLimitMax;
            AgeLimitMin = ageLimitMin;
            Weight = weight;
        }
    }
}
