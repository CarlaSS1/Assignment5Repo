/*
 * I, Andrew Panko, student number [000394436], certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 4th, 2019.
 */

/// <summary>
/// Represents an abstract bidder.
/// </summary>
public abstract class Bidder
{
    /// <summary>
    /// Defining a Bidder
    /// </summary>
    /// <param name="name">The name,</param>
    /// <param name="bid">The bid amount</param>
    /// <param name="amountToBid">The amount to bid.</param>
    /// <param name="hasWon">Flag if bidder won</param>
    public Bidder(string name, double bid, double amountToBid, bool hasWon)
    {
        this.Name = name;
        this.Bid = bid;
        this.HasWon = hasWon;
        this.AmountToBid = amountToBid;
    }

    // the name allows us to provide a unique way of identifying
    // the observer
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the bid.
    /// </summary>
    /// <value>The bid</value>
    public double Bid { get; set; }

    /// <summary>
    /// Gets or set the amount to bid
    /// </summary>
    /// <value>The amount to bid</value>
    public double AmountToBid { get; set; }

    /// <summary>
    /// Gets or sets the flag haswon
    /// </summary>
    /// <value>
    /// True: Bidder won
    /// False: Bidder lost.
    /// </value>
    public bool HasWon { get; set; }

    // provide a notify method,
    // so that the subject can notify all the observers
    // and that the sub-class observers are implemented
    public abstract void Notify();
}
