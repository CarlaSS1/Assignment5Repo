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
        /// <summary>
        /// Adds a new hard drive into the motherboard
        /// </summary>
        /// <param name="hardDrive">The hard drive</param>
        /// <returns>A motherboard with an additional hard drive</returns>
        IMotherboard<T> AddHardDrive(HardDrive hardDrive);

        /// <summary>
        /// Adds a new memory stick into the motherboard
        /// </summary>
        /// <param name="memory">The memory stick</param>
        /// <returns>A motherboard with an additional memory stick.</returns>
        IMotherboard<T> AddMemoryStick(Memory memory);

        /// <summary>
        /// Adds a new graphics card into the motherboard
        /// </summary>
        /// <param name="graphicsCard">The graphics card</param>
        /// <returns>A motherboard with a new graphics card</returns>
        IMotherboard<T> AddGraphicCard(GraphicsCard graphicsCard);

        /// <summary>
        /// Adds a new processor into the motherboard
        /// </summary>
        /// <param name="processor">The processor</param>
        /// <returns>A motherboard with a new processor</returns>
        IMotherboard<T> AddCpu(Cpu processor);

        /// <summary>
        /// Builds a new instance of type motherboard
        /// </summary>
        /// <returns>A new instance of motherboard object.</returns>
        T Build();

        // sets methods

        /// <summary>
        /// Set a hard drive limit for the motherboard.
        /// </summary>
        /// <param name="capacity">The capacity.</param>
        /// <returns>A motherboard with a new hard drive limit set.</returns>
        IMotherboard<T> SetHardDriveLimit(int capacity);

        /// <summary>
        /// Sets a new name for the motherboard.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>A motherboard with a set name.</returns>
        IMotherboard<T> SetMotherboardName(string name);

    }
}
