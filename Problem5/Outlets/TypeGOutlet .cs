namespace Problem5.Plugs
{
    /// <summary>
    /// Represent a type g outlet.
    /// </summary>
    class TypeGOutlet : Outlet
    {
        /// <summary>
        /// Initializes a new instance of <see cref="TypeGOutlet"/> class.
        /// </summary>
        public TypeGOutlet()
        {
            this.Type = OutletType.G;

            this.Amperage = 13;

            this.Voltage = 230;

            this.ProngCount = 3;

            this.IsPolarized = true;
        }        
    }
}
