using System;
using System.Collections.Generic;
using System.Text;

namespace Problem3
{
    public abstract class Handler
    {
        protected Handler()
        {

        }

        // we defined our resource as abstract
        // so that all derived handler will define the resource they handle
        public abstract string Mail { get; }

        // define an abstract handle method
        // to be implemented by all derived handlers
        // the parameter, is the resource to handle
        public abstract void Handle(Mail resource);
    }
}
