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

        // May have a variable that validates the read speed
        public string ReadSpeed { get; set; }

        // may haave a variable that validates the write speed
        public string WriteSpeed { get; set; }

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
        public HardDrive(double capacity, HardDriveType driveType, string readSpeed, string writeSpeed)
        {
            Capacity = capacity;
            DriveType = driveType;
            ReadSpeed = readSpeed ?? throw new ArgumentNullException(nameof(readSpeed));
            WriteSpeed = writeSpeed ?? throw new ArgumentNullException(nameof(writeSpeed));
        }
    }
}

// We're going to be under the assumption that the harddrive will have a gb and not a mb.
// Any hard drives under a gb will be converted to what would look like in a gb size respectivelly.
// But won't go far as KB.
// The user will be noted of that.