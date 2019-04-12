﻿/*
 * I, Kevin Tran, student number 000375580, certify that all code submitted is my own work; 
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
        private List<MailReactor> mailHandlers = new List<MailReactor>();

        private List<Mail> mails = new List<Mail>();

        public List<Mail> FlaggedMails { get; set; }

        public Mailroom()
        {
            this.mailHandlers.AddRange(typeof(Mailroom).Assembly.DefinedTypes
                                                                .Where(c => c == typeof(MailReactor) 
                                                                && !c.IsAbstract 
                                                                && c.IsClass)
                                                                .Select(t => (MailReactor)Activator.CreateInstance(t)));
        }

        public void Handle(Mail mail)
        {
            if(!mail.IsFlagged)
            {
                // Get first handler
                //var handler = this.mailHandlers.FirstOrDefault(c => c.Mail == mail.SenderInfo.Name);

                //handler.Handle(mail);
            }
            else
            {
                Console.WriteLine("Placed flagged mail into the review queue");
                this.FlaggedMails.Add(mail);
            }

            
        }
    }
}
