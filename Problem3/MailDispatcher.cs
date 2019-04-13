/*
 * I, Kevin Tran, student number 000375580, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 11, 2019
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    /// <summary>
    /// Represents an abstract mail handler.
    /// </summary>
    public class MailDispatcher
    {
        private List<Handler> handlers = new List<Handler>();

        public List<Worker> workers = new List<Worker>();

        public List<Mail> Mails { get; set; }

        public int Capacity { get; set; }

        /// <summary>
        /// Initiailizes a new instance of <see cref="MailDispatcher"/> class.
        /// </summary>
		public MailDispatcher()
		{
            if(Capacity >= 5)
            {
                workers.Capacity += 1;

                workers.Add(new Worker());
            }
            
			this.handlers.AddRange(typeof(MailDispatcher).Assembly.DefinedTypes.Where(c => c == typeof(Handler)
																			&& !c.IsAbstract
																			&& c.IsClass)
			                                      .Select(t => (Handler)Activator.CreateInstance(t)));
		}

        public void Handle(Mail resource)
		{
            if (!resource.IsFlagged)
            {
                
            }

            // find the first handler
            var handler = this.handlers.FirstOrDefault();

            if (handler == null)
            {
                throw new InvalidOperationException("Unable to locate handler for resource");
            }

            handler.Handle(resource);
		}

        public MailDispatcher(List<Mail> mails)
        {
            Mails = mails ?? throw new ArgumentNullException(nameof(mails));
        }
    }
}
