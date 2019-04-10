/*
 * I, Carla Sison, student number 000397812, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 5, 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Problem2.Parts
{
    /// <summary>
    /// Represents an interface for a Computer.
    /// </summary>
    public interface IMotherboard<out T> where T : Computer
    {
        // Add
        IMotherboard<T> AddHardDrive(HardDrive hardDrive);

        T Build();

        // sets - Might have to make another interface, oh my god. WHy.

        IMotherboard<T> SetCase(Case caseName);

        IMotherboard<T> SetHardDriveLimit(int capacity);
    }
}
