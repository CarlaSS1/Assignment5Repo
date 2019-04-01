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
    public class Motherboard
    {

        public string FormFactor { get; set; }

        public int PowerConsumption { get; set; }

        public int HardDriveLimit { get; set; }

        public int MemorySlots { get; set; }

        public int PCISlots { get; set; }

        public List<HardDrive> HardDrives { get; set; }

        public List<Memory> Memories { get; set; }

        public List<GraphicsCard> GraphicCards { get; set; }
        
        public Motherboard() {}

        public Motherboard(string formFactor, int powerConsumption, int hardDriveLimit, int memorySlots, int pCISlots)
        {
            FormFactor = formFactor ?? throw new ArgumentNullException(nameof(formFactor));
            PowerConsumption = powerConsumption;
            HardDriveLimit = hardDriveLimit;
            MemorySlots = memorySlots;
            PCISlots = pCISlots;
        }

        public Motherboard(string formFactor, int powerConsumption, int hardDriveLimit, int memorySlots, int pCISlots, List<HardDrive> hardDrives, List<Memory> memories, List<GraphicsCard> graphicCards)
        {
            FormFactor = formFactor ?? throw new ArgumentNullException(nameof(formFactor));
            PowerConsumption = powerConsumption;
            HardDriveLimit = hardDriveLimit;
            MemorySlots = memorySlots;
            PCISlots = pCISlots;
            HardDrives = hardDrives ?? throw new ArgumentNullException(nameof(hardDrives));
            Memories = memories ?? throw new ArgumentNullException(nameof(memories));
            GraphicCards = graphicCards ?? throw new ArgumentNullException(nameof(graphicCards));
        }
    }
}

// Motherboard has a graphics card
// Motherboard has a Cpu
// Motherboard has 1 to many Hard drives
// Motherboard has 1 to many memory
