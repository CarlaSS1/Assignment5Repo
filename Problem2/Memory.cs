/*
 * I, Carla Sison, student number 000397812, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 1, 2019
 */

namespace Problem2
{
    /// <summary>
    /// Stores a list of all available Memory types
    /// </summary>
    public enum MemoryType { DDR1, DDR2, DDR3, DDR4 };

    /// <summary>
    /// Represents a memory from a motherboard.
    /// </summary>
    public class Memory
    {
        // May have a variable that validates the read speed
        // May convert it into a string.
        public int ReadSpeed { get; set; }

        // May have a variable that validates the write speed
        // May convert it into a string.
        public int WriteSpeed { get; set; }

        /// <summary>
        /// Gets or sets the memory type.
        /// </summary>
        /// <value>Type of memory.</value>
        public MemoryType TypeMemory { get; set; }

        /// <summary>
        /// Gets or sets the capacity
        /// </summary>
        /// <value>The capacity</value>
        public double Capacity { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="Memory"/> class.
        /// </summary>
        public Memory() {}

        /// <summary>
        /// Initializes a new instance of <see cref="Memory"/> class.
        /// </summary>
        /// <param name="readSpeed">The read speed.</param>
        /// <param name="writeSpeed">The write speed.</param>
        /// <param name="typeMemory">The Memory type.</param>
        /// <param name="capacity">The capacity.</param>
        public Memory(int readSpeed, int writeSpeed, MemoryType typeMemory, double capacity)
        {
            ReadSpeed = readSpeed;
            WriteSpeed = writeSpeed;
            TypeMemory = typeMemory;
            Capacity = capacity;
        }
    }
}
