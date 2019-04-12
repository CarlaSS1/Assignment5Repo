namespace Problem5.Plugs
{
    /// <summary>
    /// Represents a type d outlet.
    /// </summary>
    class TypeDOutlet : Outlet
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TypeDOutlet"/> class.
        /// </summary>
        public TypeDOutlet()
        {
            this.Type = OutletType.D;

            this.Amperage = 5;

            this.Voltage = 250;

            this.ProngCount = 3;

            this.IsPolarized = true;
        }
        
    }
}
