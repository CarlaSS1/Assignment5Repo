/*
 * I, Kevin Tran, student number 000375580, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 3, 2019
 */

using System;

namespace Problem3
{
    /// <summary>
    /// Represent a mail box
    /// </summary>
    public class MailBox
    {

        /// <summary>
        /// Gets or sets the receiver information
        /// </summary>
        /// <value>The receiver information</value>
        public Receiver ReceiverInfo { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="MailBox"/> has received.
        /// </summary>
        /// <value>Whether or the user has received the mail</value>
        public bool HasReceived { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="MailBox"/> class
        /// </summary>
        public MailBox() { }

        /// <summary>
        /// Initialinzes a new instance of <see cref="MailBox"/> class.
        /// </summary>
        /// <param name="receiverInfo">The receiver information.</param>
        public MailBox( Receiver receiverInfo)
        {
            ReceiverInfo = receiverInfo ?? throw new ArgumentNullException(nameof(receiverInfo));
        }
    }
}