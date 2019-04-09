namespace Problem5
{
    public enum OutletType { A, B, C, D, G, H };

    public abstract class Outlet
    {
        public OutletType Type { get; set; }

        public double Amperage { get; set; }

        public int Voltage { get; set; }

        public int ProngCount { get; set; }

        public bool IsPolarized { get; set; }
        
        public Outlet() { }
                
    }
}
