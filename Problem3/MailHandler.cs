/*
 * I, Kevin Tran, student number [studentid], certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 11, 2019
 */

namespace Problem3
{
    /// <summary>
    /// Represents an abstract mail handler.
    /// </summary>
    public abstract class MailHandler
    {
        /// <summary>
        /// Initiailizes a new instance of <see cref="MailHandler"/> class.
        /// </summary>
        protected MailHandler() {}

        public abstract Mail Mail { get; }

        public abstract void Handle(Mail mail);
    }
}
