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
    /// Represents a motherboard
    /// </summary>
    public class Motherboard : IDisposable
    {
        /// <summary>
        /// Gets or sets a CPU
        /// </summary>
        /// <value>The CPU</value>
        /// 
        /// <remarks>
        /// To prevent confusion, it is called a Processor, which is
        /// another nickname for a CPU.
        /// </remarks>
        public Cpu Processor { get; set; }

        /// <summary>
        /// Gets or sets the name of a motherboard
        /// </summary>
        /// <value>Name of a motherboard.</value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets form factor
        /// </summary>
        /// <value>The form factor.</value>
        public string FormFactor { get; set; }

        /// <summary>
        /// Gets or sets power consumption
        /// </summary>
        /// <value>The power consumption</value>
        public double PowerConsumption { get; set; }

        /// <summary>
        /// Gets or sets Hard drive limit
        /// </summary>
        /// <value>The hard drive limit</value>
        public int HardDriveLimit { get; set; }

        /// <summary>
        /// Gets or sets memory slots
        /// </summary>
        /// <value>The memory slots.</value>
        public int MemorySlots { get; set; }

        /// <summary>
        /// Gets or sets PCI slots.
        /// </summary>
        /// <value>The PCI slots</value>
        public int PCISlots { get; set; }

        /// <summary>
        /// Gets or sets 1 to many hard drives
        /// </summary>
        /// <value>A list of hard drives.</value>
        public List<HardDrive> HardDrives { get; set; }

        /// <summary>
        /// Gets or sets 1 to many memories
        /// </summary>
        /// <value>A list of memories</value>
        public List<Memory> Memories { get; set; }

        /// <summary>
        /// Gets or sets 1 to 1 graphics card
        /// </summary>
        /// <value>A graphics card</value>
        public GraphicsCard GraphicCard { get; set; }
        
        /// <summary>
        /// Initializes a new instance of <see cref="Motherboard"/> class.
        /// </summary>
        public Motherboard() {}

        /// <summary>
        /// Initializes a new instance of <see cref="Motherboard"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="formFactor">The form factor.</param>
        /// <param name="powerConsumption">The power consumption.</param>
        /// <param name="hardDriveLimit">The hard drive limit.</param>
        /// <param name="processor">The CPU</param>
        /// <param name="memorySlots">The memory slots.</param>
        /// <param name="pCISlots">The PCI slots.</param>
        public Motherboard(string name, string formFactor, double powerConsumption, int hardDriveLimit, Cpu processor, int memorySlots, int pCISlots)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            FormFactor = formFactor ?? throw new ArgumentNullException(nameof(formFactor));
            PowerConsumption = powerConsumption;
            HardDriveLimit = hardDriveLimit;
            Processor = processor;
            MemorySlots = memorySlots;
            PCISlots = pCISlots;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Motherboard"/> class.
        /// </summary>
        /// <param name="processor">The CPU</param>
        /// <param name="name">The Name.</param>
        /// <param name="formFactor">The form factor.</param>
        /// <param name="powerConsumption">The power consumption.</param>
        /// <param name="hardDriveLimit">The hard drive limit.</param>
        /// <param name="memorySlots">The memory slots.</param>
        /// <param name="pCISlots">The PCI slots.</param>
        /// <param name="hardDrives">List of hard drives.</param>
        /// <param name="memories">A list of memories.</param>
        /// <param name="graphicCard">The graphics card.</param>
        public Motherboard(Cpu processor, string name, string formFactor, double powerConsumption, int hardDriveLimit, int memorySlots, int pCISlots, List<HardDrive> hardDrives, List<Memory> memories, GraphicsCard graphicCard)
        {
            Processor = processor;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            FormFactor = formFactor ?? throw new ArgumentNullException(nameof(formFactor));
            PowerConsumption = powerConsumption;
            HardDriveLimit = hardDriveLimit;
            MemorySlots = memorySlots;
            PCISlots = pCISlots;
            HardDrives = hardDrives ?? throw new ArgumentNullException(nameof(hardDrives));
            Memories = memories ?? throw new ArgumentNullException(nameof(memories));
            GraphicCard = graphicCard ?? throw new ArgumentNullException(nameof(graphicCard));
        }

        /// <summary>
        /// Adds the CPU into the motherboard.
        /// </summary>
        /// <param name="name">The name of Cpu.</param>
        /// <param name="speed">The speed of CPU.</param>
        /// <param name="cpuManufacturer">Cpu Manufacturer</param>
        /// <param name="socketTypes">The Socket Type</param>
        /// <param name="cacheSize">The Cache Size</param>
        /// <param name="numberOfCores">The number of cores.</param>
        public void AddCpu(string name, double speed, CpuManufacturer cpuManufacturer, CpuSocketTypes socketTypes, int cacheSize, int numberOfCores)
        {

            this.Processor = new Cpu(this, name, speed, cpuManufacturer, socketTypes, cacheSize, numberOfCores);
        }


        /// <summary>
        /// Disposes of CPU as part is being replaced
        /// </summary>
        public void Dispose()
        {
            // Might add all  the other parts/
            Processor.Dispose();
        }
    }
}

// Motherboard has a graphics card
// Motherboard is a part of a Cpu
// Motherboard has 1 to many Hard drives
// Motherboard has 1 to many memory
// Motherboard is a part of a PC.

// See this for more information about relationships: https://social.msdn.microsoft.com/Forums/en-US/0b6677dc-3eb6-4eae-9c8f-c042ccbfefb3/what-is-composition-in-c-?forum=csharplanguage
