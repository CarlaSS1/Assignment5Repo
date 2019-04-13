using System;
using System.Collections.Generic;

namespace Problem3
{
    public class Mailroom
    {
        public List<Mail> Mails { get; }

        private readonly MailDispatcher dispatcher;

        public Mailroom()
        {
            this.dispatcher = new MailDispatcher(Mails);
        }

        public Mailroom(List<Mail> mails)
        {
            Mails = mails ?? throw new ArgumentNullException(nameof(mails));
        }
    }
}
