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
    /// Stores types of available hard drive.
    /// </summary>
    public enum HardDriveType { SSD, HDD };

    /// <summary>
    /// Represents a hard drive
    /// </summary>
    public class HardDrive
    {
        private double readSpeed;

        private double writeSpeed;

        /// <summary>
        /// Gets or sets the capacity
        /// </summary>
        /// <value>The capacity.</value>
        /// 
        /// <remarks>
        /// This will be in GB.
        /// </remarks>
        public double Capacity { get; set; }

        /// <summary>
        /// Gets or sets the Hard drive type
        /// </summary>
        /// <value>The drive type.</value>
        public HardDriveType DriveType { get; set; }

        /// <summary>
        /// Gets or sets the read speed
        /// </summary>
        /// <value>The read speed</value>
        public double ReadSpeed
        {
            get { return readSpeed; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(readSpeed)} cannot be 0");
                }
                readSpeed = value;
            }
        }

        /// <summary>
        /// Gets or sets the write speed
        /// </summary>
        /// <value>The write speed</value>
        public double WriteSpeed
        {
            get { return writeSpeed; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(writeSpeed)} cannot be 0");
                }
                writeSpeed = value;
            }
        }

        /// <summary>
        /// Initializes a new instance of <see cref="HardDrive"/> class.
        /// </summary>
        public HardDrive() {}

        /// <summary>
        /// Initalizes a new instance of <see cref="HardDrive"/> class.
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        /// <param name="driveType">The Drive type.</param>
        /// <param name="readSpeed">The read speed.</param>
        /// <param name="writeSpeed">The write speed.</param>
        public HardDrive(double capacity, HardDriveType driveType, double readSpeed, double writeSpeed)
        {
            Capacity = capacity;
            DriveType = driveType;
            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
        }

        


    }
}

// We're going to be under the assumption that the harddrive will have a gb and not a mb.
// Any hard drives under a gb will be converted to what would look like in a gb size respectivelly.
// But won't go far as KB.
// The user will be noted of that.