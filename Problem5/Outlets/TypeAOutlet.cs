namespace Problem5.Plugs
{
    /// <summary>
    /// Represents a type a outlet
    /// </summary>
    class TypeAOutlet : Outlet
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TypeAOutlet"/> class.
        /// </summary>
        public TypeAOutlet()
        {
            this.Type = OutletType.A;

            this.Amperage = 15;

            this.Voltage = 120;

            this.ProngCount = 2;

            this.IsPolarized = true;
        }
        
    }
}
