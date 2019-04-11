/*
 * I, Carla Sison, student number 000397812, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 11, 2019
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Problem2.Parts;

namespace Problem2
{
    public class MotherboardBuilder : IMotherboard<Motherboard>
    {
        private readonly Motherboard motherboard;
        
        public IMotherboard<Motherboard> AddCpu(Cpu processor)
        {
            if (processor != null)
            {
                throw new ArgumentNullException($"{nameof(processor)} cannot be null");
            }
            if(processor.Speed <= 0)
            {
                throw new ArgumentOutOfRangeException($"{nameof(processor)} speed cannot be less than 0.");
            }

            this.motherboard.CpuBoard = processor;
            return this;
        }

        public IMotherboard<Motherboard> AddGraphicCard(GraphicsCard graphicsCard)
        {
            if(this.motherboard.GraphicCard == null)
            {
                throw new ArgumentNullException($"{nameof(GraphicsCard)} cannot be null");
            }

            this.motherboard.GraphicCard = graphicsCard;
            return this;
        }

        public IMotherboard<Motherboard> AddHardDrive(HardDrive hardDrive)
        {
            // Has the motherboard passed it's hard drive limit
            if(this.motherboard.HardDriveLimit >= this.motherboard.HardDrives.Count())
            {
                Console.WriteLine("Hard drive capacity is full. Please remove one if you wish to add a new one.");
                return this;
            }

            this.motherboard.HardDrives.Add(hardDrive);

            if(this.motherboard.HardDriveLimit == this.motherboard.HardDrives.Count())
            {
                Console.WriteLine($"Mother board has reached it's hard drive capacity.");
            }

            return this;
        }

        public IMotherboard<Motherboard> AddMemory(Memory memory)
        {
            // Has the motherboard passed it's hard drive limit
            if (this.motherboard.MemorySlots >= this.motherboard.Memories.Count())
            {
                Console.WriteLine("Memory Slot capacity is full. Please remove one if you wish to add a new one.");
                return this;
            }

            this.motherboard.Memories.Add(memory);

            if (this.motherboard.MemorySlots == this.motherboard.Memories.Count())
            {
                Console.WriteLine($"Memory Slots has reached its capacity.");
            }

            return this;
        }
        
        public MotherboardBuilder()
        {
            this.motherboard = new Motherboard();
        }

        public Motherboard Build()
        {
            return this.motherboard;
        }

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

        // Validation for the 
    }
}
