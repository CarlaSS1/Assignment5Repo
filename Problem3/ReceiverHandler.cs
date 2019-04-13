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
    /// Represents handler for receiver mail
    /// </summary>
    public class ReceiverHandler : Handler
    {
        /// <summary>
        /// Initializes a new instance of <see cref="ReceiverHandler"/> class.
        /// </summary>
        public ReceiverHandler() {}
        
        /// <summary>
        /// Sets the mail
        /// </summary>
        public override string Mail => "Mail";

        /// <summary>
        /// Handles receiver mail. 
        /// </summary>
        /// <param name="mail">The mail.</param>
        public override void Handle(Mail mail)
        {
            Console.WriteLine($"Sent Mail into the Receiver Mailbox.");
        }
    }
}
