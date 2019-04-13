using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public class MailHandler : Handler
    {
        public MailHandler()
        {

        }

        public override Mail Mail => null;

        public override void Handle(Mail resource)
        {
            Console.WriteLine($"Mail: {resource.PostalCost}");
        }
    }
}
