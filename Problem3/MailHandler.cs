/*
 * I, Kevin Tran, student number 000375580, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 11, 2019
 */

using System;
using System.Collections.Generic;

namespace Problem3
{
    /// <summary>
    /// Represents a handler for mail
    /// </summary>
    public class MailHandler : Handler
    {
        // A collection of mail
        public Queue<Mail> mailCollection;

        // Mail that is viewed to a dispatcher
        public List<MailBox> mailBoxesCollection;

        /// <summary>
        /// Sets a mail
        /// </summary>
        public override string Mail => "Mail";

        /// <summary>
        /// Initinalizes a new instance of <see cref="MailHandler"/> class.
        /// </summary>
        /// <param name="mailBoxesCollection">A collection of mail boxes</param>
        public MailHandler(List<MailBox> mailBoxesCollection)
        {
            this.mailCollection = new Queue<Mail>();
            this.mailBoxesCollection = mailBoxesCollection;
        }

        /// <summary>
        /// Handles a piece of mail
        /// </summary>
        /// <param name="mail">The mail.</param>
        public override void Handle(Mail mail)
        {
            // Check if the mail is flagged or not.
            if (!mail.IsFlagged)
            {
                Console.WriteLine("Determine which mailbox");

                foreach (var mailBox in mailBoxesCollection)
                {
                    if (mail.ReceiverInfo == mailBox.ReceiverInfo)
                    {
                        mailBox.HasReceived = true;
                    }
                }
            }
            else
            {
                Console.WriteLine("Placed flagged mail into the review queue");
                mailCollection.Enqueue(mail);
            }

        }
    }
}
