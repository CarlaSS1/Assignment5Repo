/*
 * I, Kevin Tran, student number 000375580, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 11, 2019
 */

namespace Problem3
{
    /// <summary>
    /// Represents an abstract handler
    /// </summary>
    public abstract class Handler
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Handler"/> class.
        /// </summary>
        protected Handler() {}

        /// <summary>
        /// Gets a mail
        /// </summary>
        public abstract string Mail { get; }
        
        /// <summary>
        /// Handles a mail for a handler.
        /// </summary>
        /// <param name="mail">The mail</param>
        public abstract void Handle(Mail mail);
    }
}