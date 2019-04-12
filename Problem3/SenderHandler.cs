using System;

namespace Problem3
{
    public class SenderHandler : MailHandler
    {
        public SenderHandler()
        {

        }

        public override string Mailbox => "owo";

        public override void Handle(Mail mail)
        {
            Console.WriteLine($"Mail: {mail.SenderInfo.ToString()}");
        }

        public void SendToMailroom()
        {

        }
    }
}
