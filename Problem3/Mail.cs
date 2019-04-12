﻿/*
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
    /// Represent a mail from a mailroom
    /// </summary>
    public class Mail
    {
        /// <summary>
        /// Gets or sets the weight of the mail
        /// </summary>
        /// <value>Weight of the mail</value>
        public double Weight { get; set; }

        /// <summary>
        /// Gets or sets the postal cost
        /// </summary>
        /// <value>The postal code</value>
        public double PostalCost { get; set; }

        /// <summary>
        /// Gets or sets flagged mail
        /// </summary>
        /// <value>Flagged mail</value>
        public bool IsFlagged { get; set; }

        /// <summary>
        /// Gets or sets the Sender info
        /// </summary>
        /// <value>The Sender information</value>
        public Sender SenderInfo { get; set; }

        /// <summary>
        /// Gets or sets the receiver information
        /// </summary>
        /// <value>The receiver information</value>
        public Receiver ReceiverInfo { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="Mail"/> class
        /// </summary>
        public Mail()
        {

        }

    }
}

// You can ignore priority. That's not important to the assignment.
