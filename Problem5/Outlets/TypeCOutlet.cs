namespace Problem5.Plugs
{
    /// <summary>
    /// Represents a type c outlet.
    /// </summary>
    class TypeCOutlet : Outlet
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TypeCOutlet"/> class.
        /// </summary>
        public TypeCOutlet()
        {
            this.Type = OutletType.C;

            this.Amperage = 2.5;

            this.Voltage = 250;

            this.ProngCount = 2;

            this.IsPolarized = true;
        }
        
    }
}
