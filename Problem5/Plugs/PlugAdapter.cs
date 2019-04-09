using System;
using System.Collections.Generic;
using System.Text;

namespace Problem5.Plugs
{
    class PlugAdapter : Outlet
    {
        protected Outlet Outlet;

        public PlugAdapter()
        {
        }

        public T Adapt<T>(Outlet outlet) where T : Outlet
        {
            return (T)Adapt( outlet );
        }
        
        public object Adapt( Outlet outlet )
        {
            switch ( outlet )
            {
                case TypeAOutlet a:

                    this.Outlet = new TypeAOutlet();

                    break;
                case TypeBOutlet b:

                    this.Outlet = new TypeBOutlet();

                    break;
                case TypeCOutlet c:

                    this.Outlet = new TypeCOutlet();

                    break;
                case TypeDOutlet d:

                    this.Outlet = new TypeDOutlet();

                    break;
                case TypeGOutlet g:

                    this.Outlet = new TypeGOutlet();

                    break;
                case TypeHOutlet h:

                    this.Outlet = new TypeHOutlet();

                    break;
                default:
                    throw new Exception("There is no existing outlet that this plug can be adapted to, please try a valid plug type.");
                 
            }

            return this.Outlet;
        }
    }
}