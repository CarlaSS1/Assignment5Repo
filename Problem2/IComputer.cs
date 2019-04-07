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

namespace Problem2
{
    /// <summary>
    /// Represents an interface for a Computer.
    /// </summary>
    public interface IComputer<out T> where T : Computer
    {
        IComputer<T> AddHardDrive(int count);

        IComputer<T> AddMotherBoard(Motherboard board);

        IComputer<T> AddCase(int count);

        // not sure if this is necessary
        T Build();

        // TO DO - Find a propety that is typically set in a computer.
        IComputer<T> SetHardDrive(int count);

        IComputer<T> SetCase(int count);

        IComputer<T> SetMotherBoard(int count);

        IComputer<T> SetCpuSpeed(double speed);
    }
}
