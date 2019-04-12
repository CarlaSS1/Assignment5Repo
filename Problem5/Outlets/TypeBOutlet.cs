namespace Problem5.Plugs
{
    /// <summary>
    /// Represents a type b outlet.
    /// </summary>
    class TypeBOutlet : Outlet
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TypeBOutlet"/> class.
        /// </summary>
        public TypeBOutlet()
        {
            this.Type = OutletType.B;

            this.Amperage = 15;

            this.Voltage = 120;

            this.ProngCount = 3;

            this.IsPolarized = true;
        }
        
    }
}
