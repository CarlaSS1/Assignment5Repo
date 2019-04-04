/*
 * I, Kevin Tran, student number [studentid], certify that all code submitted is my own work; 
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
    /// Represents a receiver of a mail.
    /// </summary>
    public class Receiver
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public Receiver()
        {

        }

        public Receiver(string name, string address)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Address = address ?? throw new ArgumentNullException(nameof(address));
        }
    }
}
