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
    /// Represent a mail from a mailroom
    /// </summary>
    public class MailBox
    {

        /// <summary>
        /// Gets or sets the receiver information
        /// </summary>
        /// <value>The receiver information</value>
        public Receiver ReceiverInfo { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="T:Problem3.MailBox"/> has received.
        /// </summary>
        /// <value><c>true</c> if has received; otherwise, <c>false</c>.</value>
        public bool HasReceived { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="MailBox"/> class
        /// </summary>
        public MailBox() { }

        /// <summary>
        /// Initializes a new instance of <see cref="MailBox"/> class.
        /// </summary>
        /// <param name="weight">The Weight</param>
        /// <param name="postalCost">The postal cost.</param>
        /// <param name="isFlagged">Status if the mail is flagged or not.</param>
        /// <param name="senderInfo">Sender Information</param>
        /// <param name="receiverInfo">Receiver Information</param>
        public MailBox( Receiver receiverInfo)
        {
            ReceiverInfo = receiverInfo ?? throw new ArgumentNullException(nameof(receiverInfo));
        }
    }
}