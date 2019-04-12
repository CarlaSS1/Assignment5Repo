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
    public abstract class MailReactor
    {
        private List<Handler> handlers = new List<Handler>();

        /// <summary>
        /// Initiailizes a new instance of <see cref="MailReactor"/> class.
        /// </summary>
		public MailReactor()
		{

			this.handlers.AddRange(typeof(MailReactor).Assembly.DefinedTypes.Where(c => c == typeof(Handler)
																			&& !c.IsAbstract
																			&& c.IsClass)
			                                      .Select(t => (Handler)Activator.CreateInstance(t)));
		}

        public void Handle(Mail resource)
		{
			// find the first handler
			var handler = this.handlers.FirstOrDefault(c => c.Mail == resource.ReceiverInfo.Name);

			if (handler == null)
			{
				throw new InvalidOperationException("Unable to locate handler for resource");
			}

			handler.Handle(resource);
		}
    }
}
