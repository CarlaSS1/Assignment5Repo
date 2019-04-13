using System;
using System.Collections.Generic;

namespace Problem3
{
    public class Mailroom
    {
        public List<Mail> Mails { get; set; }
        public List<MailBox> MailBoxCollection { get; set; }

        private readonly MailDispatcher dispatcher;

        public Mailroom(List<MailBox> mailBoxes)
        {
            this.dispatcher = new MailDispatcher(Mails);
            this.MailBoxCollection = mailBoxes;
        }

        public Mailroom(List<Mail> mails)
        {
            Mails = mails ?? throw new ArgumentNullException(nameof(mails));
        }
    }
}
