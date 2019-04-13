using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public class MailHandler : Handler
    {
        public Queue<Mail> mailCollection;
        public List<MailBox> mailBoxesCollection;

        public MailHandler(List<MailBox> mailBoxesCollection)
        {

            this.mailCollection = new Queue<Mail>();
            this.mailBoxesCollection = mailBoxesCollection;

        }

        public override string Mail => "Mail";

        public override void Handle(Mail mail)
        {
           

            if (!mail.IsFlagged)
            {
                Console.WriteLine("Determine which mailbox");

                foreach (var mailBox in mailBoxesCollection)
                {
                    if (mail.ReceiverInfo == mailBox.ReceiverInfo)
                    {
                        mailBox.HasReceived = true;
                    }
                }

            }
            else
            {

                Console.WriteLine("Placed flagged mail into the review queue");
                mailCollection.Enqueue(mail);

               
            }

        }
    }
}
