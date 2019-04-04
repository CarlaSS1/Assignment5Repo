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
    public enum AdapterRating { Amperage, Voltage };

    public enum AdapterPolarized { Polarized, Not_Polarized };

    public class Adapter
    {
        public int ProngCount { get; set; }

        public AdapterRating Rating { get; set; }

        public AdapterPolarized Polarized{ get; set; }

        // Property for Type A through L

        public Adapter() {}


    }
}

// Research is required.
// I found this, it might be useful: https://github.com/kamranahmedse/design-patterns-for-humans
