/*
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
    public class Worker
    {
        private List<MailDispatcher> mailHandlers = new List<MailDispatcher>();

        private List<Handler> handlers = new List<Handler>();

        public List<Mail> mails = new List<Mail>();

        public List<Mail> FlaggedMails { get; set; }

        public int Capacity { get; set; }

        public List<Worker> Workers = new List<Worker>();

        public Worker()
        {
            this.mailHandlers.AddRange(typeof(Worker).Assembly.DefinedTypes
                                                                .Where(c => c == typeof(MailDispatcher) 
                                                                && !c.IsAbstract 
                                                                && c.IsClass)
                                                                .Select(t => (MailDispatcher)Activator.CreateInstance(t)));
        }

        public void Handle(Mail mail)
        {
            if(!mail.IsFlagged)
            {
                var handler = this.handlers.FirstOrDefault(c => c.Mail == mail.ReceiverInfo.Name);

                handler.Handle(mail);
            }
            else
            {
                Console.WriteLine("Placed flagged mail into the review queue");
                this.FlaggedMails.Add(mail);
            }

            
        }

        public Mail GetMail()
        {

            return mails;
        }

        public void IsFull()
        {
            if(Workers.Count() >= Capacity)
            {
                Capacity = Workers.Count() + 1;
            }
            else
            {
                Console.WriteLine($"Mail {nameof(Capacity)} is not full");
            }
        }
    }
}
