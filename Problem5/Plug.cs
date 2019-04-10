/*
 * I, Steven Thompson, student number [studentid], certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: Date you created the class.
 */

using System;

namespace Problem5
{
    public enum PlugType { A, B, C, D, G, H};

    public abstract class Plug
    {
        public PlugType Type { get; set; }

        public double Amperage { get; set; }

        public int Voltage { get; set; }

        public int ProngCount { get; set; }

        public bool IsPolarized { get; set; }

        public bool IsConnected { get; set; }

        public Plug(){}

        public virtual void Connect(Outlet outlet)
        {
            
        }

        public virtual void Disconnect()
        {
            
        }
    }


}

// Research is required.
// I found this, it might be useful: https://github.com/kamranahmedse/design-patterns-for-humans
