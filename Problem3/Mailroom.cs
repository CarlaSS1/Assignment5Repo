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
    /// Represents a mailroom
    /// </summary>
    public class Mailroom
    {
        // maintain the current instance of mail dispatcher
        private readonly MailDispatcher dispatcher;

        /// <summary>
        /// Gets or sets a list of mail
        /// </summary>
        /// <value>A list of mail</value>
        public List<Mail> Mails { get; set; }

        /// <summary>
        /// Gets or sets a collection mail boxes.
        /// </summary>
        /// <value>A collection of mail boxes./</value>
        public List<MailBox> MailBoxCollection { get; set; }

        /// <summary>
        /// Initializes a new instance of <see cref="Mailroom"/> class.
        /// </summary>
        /// <param name="mailBoxes">A list of mailboxes.</param>
        public Mailroom(List<MailBox> mailBoxes)
        {
            this.dispatcher = new MailDispatcher(Mails);
            this.MailBoxCollection = mailBoxes;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="Mailroom"/> class.
        /// </summary>
        /// <param name="mails">A list of mails/</param>
        public Mailroom(List<Mail> mails)
        {
            Mails = mails ?? throw new ArgumentNullException(nameof(mails));
        }
    }
}
