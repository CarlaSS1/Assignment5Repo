using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public class SenderHandler : MailHandler
    {
        public override Mail GetMail => throw new NotImplementedException();

        public override void Handle(Mail mail)
        {
            throw new NotImplementedException();
        }
    }
}
