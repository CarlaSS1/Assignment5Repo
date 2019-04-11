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
        // Computer has a case.

        // If it is solid data, don't make an interface
        IComputer<T> AddCase();

        T Build();

        // sets - Might have to make another interface, oh my god. WHy.

        IComputer<T> SetPCName(string name);
    }
}
