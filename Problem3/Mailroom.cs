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
        private List<MailHandler> handleMails = new List<MailHandler>();

        public Mailroom()
        {
            this.handleMails.AddRange(typeof(Mailroom).Assembly.DefinedTypes
                                                                .Where(c => c == typeof(MailHandler) 
                                                                && !c.IsAbstract 
                                                                && c.IsClass)
                                                                .Select(t => (MailHandler)Activator.CreateInstance(t)));
        }

        public void Handle(Queue<Mail> flaggedMail)
        {
            var handler = this.handleMails.FirstOrDefault(c => c.)
        }
    }
}
