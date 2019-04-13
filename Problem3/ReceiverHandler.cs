/*
 * I, Kevin Tran, student number 000375580, certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 11, 2019
 */

using System;

namespace Problem3
{
    public class ReceiverHandler : Handler
    {
        public ReceiverHandler()
        {

        }

        public override string Mail => "Receiver";

        public override void Handle(Mail resource)
        {
            throw new NotImplementedException();
        }
    }
}
