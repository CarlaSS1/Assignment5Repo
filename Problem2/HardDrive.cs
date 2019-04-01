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
        public int Capacity { get; set; }

        public HardDriveType HardDriveType { get; set; }

        // May have a variable that validates the read speed
        public string ReadSpeed { get; set; }

        // may haave a variable that validates the write speed
        public string WriteSpeed { get; set; }

        public HardDrive() {}

        public HardDrive(int capacity, HardDriveType hardDriveType, string readSpeed, string writeSpeed)
        {
            Capacity = capacity;
            HardDriveType = hardDriveType;
            ReadSpeed = readSpeed ?? throw new ArgumentNullException(nameof(readSpeed));
            WriteSpeed = writeSpeed ?? throw new ArgumentNullException(nameof(writeSpeed));
        }
    }
}
