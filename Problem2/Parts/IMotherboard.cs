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
    /// Represents an interface for a motherboard.
    /// </summary>
    public interface IMotherboard<out T> where T : Motherboard
    {
        // Add
        IMotherboard<T> AddHardDrive(HardDrive hardDrive);

        IMotherboard<T> AddMemory(Memory memory);

        IMotherboard<T> AddGraphicCard(GraphicsCard graphicsCard);

        IMotherboard<T> AddCpu(Cpu processor);

        T Build();

        // sets - Might have to make another interface, oh my god. WHy.

        IMotherboard<T> SetHardDriveLimit(int capacity);

        IMotherboard<T> SetMotherboardName(string name);

    }
}
