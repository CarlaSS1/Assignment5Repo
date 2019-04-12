/*
 * I, Kevin Tran, student number [studentid], certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 1, 2019
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    /// <summary>
    /// Represents a mailroom.
    /// </summary>
    public class Mailroom
    {
        private List<MailHandler> mailHandlers = new List<MailHandler>();

        private List<Mail> mails = new List<Mail>();

        public List<Mail> FlaggedMails { get; set; }

        public Mailroom()
        {
            this.mailHandlers.AddRange(typeof(Mailroom).Assembly.DefinedTypes
                                                                .Where(c => c == typeof(MailHandler) 
                                                                && !c.IsAbstract 
                                                                && c.IsClass)
                                                                .Select(t => (MailHandler)Activator.CreateInstance(t)));
        }

        public void Handle(Mail mail)
        {
            if(!mail.IsFlagged)
            {
                var handler = this.mailHandlers.FirstOrDefault(c => c.Mailbox == mail.SenderInfo.Name);

                handler.Handle(mail);
            }
            else
            {
                Console.WriteLine("Placed flagged mail into the review queue");
                this.FlaggedMails.Add(mail);
            }

            
        }
    }
}
