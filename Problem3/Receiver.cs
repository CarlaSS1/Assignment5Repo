/*
 * I, Kevin Tran, student number [studentid], certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 3, 2019
 */

using System;

namespace Problem3
{
    /// <summary>
    /// Represents a receiver of a mail.
    /// </summary>
    public class Receiver
    {
        /// <summary>
        /// Gets or sets the name of the receiver
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets receiver Address
        /// </summary>
        /// <value>The address.</value>
        public string Address { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="Receiver"/> class.
        /// </summary>
        public Receiver()
        {

        }

        /// <summary>
        /// Initializes a new instance of <see cref="Receiver"/> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        public Receiver(string name, string address)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Address = address ?? throw new ArgumentNullException(nameof(address));
        }
    }
}
