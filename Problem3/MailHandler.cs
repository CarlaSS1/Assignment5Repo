using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    class MailHandler : Handler
    {
        public MailHandler()
        {

        }

        public override string Mail => "Mail";

        public override void Handle(Mail resource)
        {
            Console.WriteLine($"Mail: {resource.PostalCost}");
        }
    }
}
