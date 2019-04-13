/*
 * I, Kevin Tran, student number 000375580, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 11, 2019
 */

using System;

namespace Problem3
{
    /// <summary>
    /// Represents a handle for sender mail
    /// </summary>
    public class SenderHandler : Handler
    {
        /// <summary>
        /// Initializes a new instance of <see cref="SenderHandler"/> class.
        /// </summary>
        public SenderHandler() {}

        /// <summary>
        /// Set the Mail
        /// </summary>
        public override string Mail => "Mail";

        /// <summary>
        /// Handles the sender mail
        /// </summary>
        /// <param name="mail">The mail.</param>
        public override void Handle(Mail mail)
        {
            Console.WriteLine($"Sent Mail into the Sender Mailbox.");
        }
    }
}
