/*
 * I, Andrew Panko, student number [000394436], certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 4th, 2019.
 */

namespace Problem4
{
    /// <summary>
    /// Represents an abstract bidder.
    /// </summary>
    public abstract class Bidder
    {
        /// <summary>
        /// Initializes a new instance of <see cref="Bidder"/> class
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="bid">The current bid.</param>
        /// <param name="amountToBid">The amount able to bid.</param>
        /// <param name="hasWon">Flag for bidder has won.</param>
        public Bidder(string name, double bid, double amountToBid, bool hasWon)
        {
            this.Name = name;
            this.Bid = bid;
            this.HasWon = hasWon;
            this.AmountToBid = amountToBid;
        }

        /// <summary>
        /// Gets or sets the name of the bidder
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the current bid
        /// </summary>
        /// <value>The bid.</value>
        public double Bid { get; set; }

        /// <summary>
        /// Gets or sets the total amount a bidder can bid
        /// </summary>
        /// <value>The total amount bidder has.</value>
        public double AmountToBid { get; set; }

        /// <summary>
        /// Gets or sets flag for the bidder has won
        /// </summary>
        /// <value>Flag for bidder: True (Won auction), false (Hasn't won auction)</value>
        public bool HasWon { get; set; }

        /// <summary>
        /// Notifies all bidders.
        /// </summary>
        public abstract void Notify();
    }
}