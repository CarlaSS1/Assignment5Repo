using System;

public abstract class Bidder
{
    /// <summary>
    /// Defining a Bidder
    /// </summary>
    /// <param name="name"></param>
    /// <param name="bid"></param>
    /// <param name="amountToBid"></param>
    /// <param name="hasWon"></param>
    public Bidder(string name, double bid, double amountToBid, bool hasWon)
    {
        this.Name = name;
        this.Bid = bid;
        this.HasWon = hasWon;
        this.amountToBid = amountToBid;
    }

    // the name allows us to provide a unique way of identifying
    // the observer
    public string Name { get; }

    public double Bid { get; set; }

    public double amountToBid { get; set; }

    public bool HasWon { get; set; }

    // provide a notify method,
    // so that the subject can notify all the observers
    // and that the sub-class observers are implemented
    public abstract void Notify();
}
