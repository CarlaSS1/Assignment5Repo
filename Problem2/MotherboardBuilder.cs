/*
 * I, Carla Sison, student number 000397812, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 11, 2019
 */

using System;
using System.Linq;
using Problem2.Parts;

namespace Problem2
{
    /// <summary>
    /// Represents a builder class for the motherboard
    /// That implements the IMotherboard methods
    /// </summary>
    public class MotherboardBuilder : IMotherboard<Motherboard>
    {
        // Maintains the current motherboard object
        private readonly Motherboard motherboard;
        
        /// <summary>
        /// Adds a new cpu processor
        /// </summary>
        /// <param name="processor">The processor</param>
        /// <returns>A motherboard with a new processor</returns>
        public IMotherboard<Motherboard> AddCpu(Cpu processor)
        {
            // Is the processor null
            if (processor == null)
            {
                throw new ArgumentNullException($"{nameof(processor)} cannot be null");
            }

            // Ensure that the cpu speed is not 0 or less.
            if(processor.Speed <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(processor)} speed cannot be less than 0.");
            }

            this.motherboard.CpuBoard = processor;
            return this;
        }

        /// <summary>
        /// Adds a new graphics card to the motherboard
        /// </summary>
        /// <param name="graphicsCard">The graphics card</param>
        /// <returns>A motherboard with a new graphics card</returns>
        public IMotherboard<Motherboard> AddGraphicCard(GraphicsCard graphicsCard)
        {
            // Make sure the graphics card is not null
            if(this.motherboard.GraphicCard == null)
            {
                throw new ArgumentNullException($"{nameof(GraphicsCard)} cannot be null");
            }

            this.motherboard.GraphicCard = graphicsCard;
            return this;
        }

        /// <summary>
        /// Adds a hard drive into the motherboard
        /// </summary>
        /// <param name="hardDrive">The hard drive</param>
        /// <returns>The motherboard with a new hard drive</returns>
        public IMotherboard<Motherboard> AddHardDrive(HardDrive hardDrive)
        {
            // Has the motherboard passed it's hard drive limit
            if(this.motherboard.HardDriveLimit >= this.motherboard.HardDrives.Count())
            {
                Console.WriteLine("Hard drive capacity is full. Please remove one if you wish to add a new one.");
                return this;
            }

            this.motherboard.HardDrives.Add(hardDrive);

            // Check if the motherboard has reached it's hard drive limit
            if(this.motherboard.HardDriveLimit == this.motherboard.HardDrives.Count())
            {
                Console.WriteLine($"Mother board has reached it's hard drive capacity.");
            }

            return this;
        }

        /// <summary>
        /// Adds a memory stick into the motherboard
        /// </summary>
        /// <param name="memoryStick">The memory stick</param>
        /// <returns>A motherboard with an additional memory stick</returns>
        public IMotherboard<Motherboard> AddMemoryStick(Memory memoryStick)
        {
            // Has the motherboard passed it's memory slot limit
            if (this.motherboard.MemorySlots >= this.motherboard.MemorySticks.Count())
            {
                Console.WriteLine("Memory Slot capacity is full. Please remove one if you wish to add a new one.");
                return this;
            }

            this.motherboard.MemorySticks.Add(memoryStick);

            // Check if there's any memory slots left in the motherboard.
            if (this.motherboard.MemorySlots == this.motherboard.MemorySticks.Count())
            {
                Console.WriteLine($"Memory Slots has reached its capacity.");
            }

            return this;
        }
        
        /// <summary>
        /// Initializes a new instance of <see cref="Motherboard"/> class.
        /// </summary>
        public MotherboardBuilder()
        {
            this.motherboard = new Motherboard();
        }

        /// <summary>
        /// Builds a new instance of motherboard object.
        /// </summary>
        /// <returns></returns>
        public Motherboard Build()
        {
            return this.motherboard;
        }

        /// <summary>
        /// Sets the hard drive limit for the motherboard
        /// </summary>
        /// <param name="capacity">The capacity</param>
        /// <returns>A motherboard with a new hard drive limit</returns>
        public IMotherboard<Motherboard> SetHardDriveLimit(int capacity)
        {
            if(capacity <= 0)
            {
                throw new ArgumentOutOfRangeException($"Hard drive {nameof(capacity)} cannot be 0.");
            }
            else
            {
                this.motherboard.HardDriveLimit = capacity;
                return this;
            }
        }

        /// <summary>
        /// Sets the name of the motherboard
        /// </summary>
        /// <param name="name">The name</param>
        /// <returns>A mother with a new name set.</returns>
        public IMotherboard<Motherboard> SetMotherboardName(string name)
        {
            if (name != null)
            {
                throw new ArgumentNullException ($"{nameof(name)} for the motherboard cannot be null");
            }
            else
            {
                this.motherboard.Name = name;
                return this;
            }
        }
    }
}
