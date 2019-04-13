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
    public class Mailroom
    {
        public List<Mail> Mails { get; set; }
        public List<MailBox> MailBoxCollection { get; set; }

        private readonly MailDispatcher dispatcher;

        public Mailroom(List<MailBox> mailBoxes)
        {
            this.dispatcher = new MailDispatcher(Mails);
            this.MailBoxCollection = mailBoxes;
        }

        public Mailroom(List<Mail> mails)
        {
            Mails = mails ?? throw new ArgumentNullException(nameof(mails));
        }
    }
}
