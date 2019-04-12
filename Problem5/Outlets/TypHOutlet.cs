namespace Problem5.Plugs
{
    /// <summary>
    /// Represents a type h outlet
    /// </summary>
    class TypeHOutlet : Outlet
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TypeHOutlet"/> class.
        /// </summary>
        public TypeHOutlet()
        {
            this.Type = OutletType.H;

            this.Amperage = 16;

            this.Voltage = 250;

            this.ProngCount = 3;

            this.IsPolarized = true;
        }
        
    }
}
