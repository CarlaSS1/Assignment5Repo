/*
 * I, Carla Sison, student number 000397812, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 1, 2019
 */

using System;
using System.Collections.Generic;

namespace Problem2
{
    /// <summary>
    /// Represents a motherboard
    /// </summary>
    public class Motherboard
    {
        /// <summary>
        /// Gets or sets the Cpu board
        /// </summary>
        /// <value>The Cpu board</value>
        public Cpu CpuBoard { get; set; }

        /// <summary>
        /// Gets or sets the name of the motherboard
        /// </summary>
        /// <value>THe Name.</value>
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
        /// Gets or sets 1 to many memories sticks
        /// </summary>
        /// <value>A list of memory sticks</value>
        public List<Memory> MemorySticks { get; set; }

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
        /// <param name="name">The name</param>
        /// <param name="formFactor">The form factor.</param>
        /// <param name="powerConsumption">The power consumption.</param>
        /// <param name="hardDriveLimit">The hard drive limit.</param>
        /// <param name="cpuBoard">The Cpu board.</param>
        /// <param name="memorySlots">The memory slots.</param>
        /// <param name="pCISlots">The PCI slots.</param>
        /// <param name="hardDrives">List of hard drives.</param>
        /// <param name="memorySticks">A list of memory sticks.</param>
        /// <param name="graphicCard">The graphics card.</param>
        public Motherboard(string name, string formFactor, double powerConsumption, int hardDriveLimit, Cpu cpuBoard, int memorySlots, int pCISlots, List<HardDrive> hardDrives, List<Memory> memorySticks, GraphicsCard graphicCard)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            FormFactor = formFactor ?? throw new ArgumentNullException(nameof(formFactor));
            PowerConsumption = powerConsumption;
            HardDriveLimit = hardDriveLimit;
            CpuBoard = cpuBoard;
            MemorySlots = memorySlots;
            PCISlots = pCISlots;
            HardDrives = hardDrives ?? throw new ArgumentNullException(nameof(hardDrives));
            MemorySticks = memorySticks ?? throw new ArgumentNullException(nameof(memorySticks));
            GraphicCard = graphicCard ?? throw new ArgumentNullException(nameof(graphicCard));
        }
    }
}

// Motherboard has a graphics card
// Motherboard has a Cpu
// Motherboard has 1 to many Hard drives
// Motherboard has 1 to many memory
