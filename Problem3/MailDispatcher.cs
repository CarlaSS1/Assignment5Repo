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
        // Holds a list of handlers
        private List<Handler> handlers = new List<Handler>();

        // Holds a list of workers
        public List<Worker> workers = new List<Worker>();

        /// <summary>
        /// Gets or sets a list of mails
        /// </summary>
        /// <value>A list of mails</value>
        public List<Mail> Mails { get; set; }

        /// <summary>
        /// Gets or sets the capacity of workers.
        /// </summary>
        public int WorkerCapacity { get; set; }

        /// <summary>
        /// Initiailizes a new instance of <see cref="MailDispatcher"/> class.
        /// </summary>
		public MailDispatcher()
		{
            // Check if the worker capacity is greater than 5
            if(workers.Count() >= WorkerCapacity)
            {
                // Increase the worker capacity
                workers.Capacity += 1;

                workers.Add(new Worker());
            }
            
			this.handlers.AddRange(typeof(MailDispatcher).Assembly.DefinedTypes.Where(c => c == typeof(MailHandler)
																			&& !c.IsAbstract
																			&& c.IsClass)
			                                      .Select(t => (MailHandler)Activator.CreateInstance(t)));
		}

        /// <summary>
        /// Initializes a new instance of <see cref="MailDispatcher"/> class.
        /// </summary>
        /// <param name="mails">A List of mails</param>
        public MailDispatcher(List<Mail> mails)
        {
            Mails = mails ?? throw new ArgumentNullException(nameof(mails));
        }
    }
}
