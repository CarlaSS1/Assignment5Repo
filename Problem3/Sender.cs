/*
 * I, Kevin Tran, student number 000375580, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 3, 2019
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    /// <summary>
    /// Represents a sender of a mail.
    /// </summary>
    public class Sender
    {
        /// <summary>
        /// Gets or sets the name of sender.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the address of a sender.
        /// </summary>
        /// <value>The address.</value>
        public string Address { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="Sender"/> class.
        /// </summary>
        public Sender() {}

        /// <summary>
        /// Initializes a new instance of <see cref="Sender"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="address">The address.</param>
        public Sender(string name, string address)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Address = address ?? throw new ArgumentNullException(nameof(address));
        }
    }
}
