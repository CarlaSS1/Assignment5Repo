/*
 * I, Andrew Panko, student number [000394436], certify that all code submitted is my own work; 
 * that I have not copied it from any other source. I also certify that I have not allowed my work to 
 * be copied by others.
 * 
 * Date: April 4th, 2019.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Problem4
{
    /// <summary>
    /// Represents an auction
    /// </summary>
    public class Auction
    {
        public class Subject
	    {
		    private readonly List<Bidder> listOfBidders;
            private readonly Stack<Bidder> bidderStack;

		    public Subject()
		    {
			    // maintain a list of observers
			    this.listOfBidders = new List<Bidder>();
                // maintain a stack of bidders
                this.bidderStack = new Stack<Bidder>();
		    }
            
            /// <summary>
            ///  
            /// </summary>
            /// <param name="observer"></param>
		    public void AddObserver(Bidder observer)
		    {
			    // only add the observer
			    // if there is no observer already added with the given name
			    if (this.listOfBidders.All(c => c.Name != observer.Name))
			    {
				    this.listOfBidders.Add(observer);
			    }
		    }

		    public void RemoveObserver(string name)
		    {
			    // remove all the observers from the list
			    // where the name of the observer matches the name provided
			    this.listOfBidders.RemoveAll(c => c.Name == name);
		    }

		    public void NotifyAll()
		    {
			    // for each observer, invoke the notify method
			    // on the given observer
			    foreach (var simpleObserver in this.listOfBidders)
			    {
				    simpleObserver.Notify();
			    }
		    }
	    }
       

	    public class BidderNumberOne : Bidder
	    {
		    public BidderNumberOne(string name, double amountToBid, double bid, bool hasWon) : base(name, amountToBid, bid, hasWon)
		    {

		    }

		    public override void Notify()
		    {
			    // called when the notify method on the super class observer is called
			    Console.WriteLine("I am observer A");
		    }
	    }

	    public class BidderNumberTwo : Bidder
	    {
		    public BidderNumberTwo(string name, double amountToBid, double bid, bool hasWon) : base(name, amountToBid, bid, hasWon)
		    {

		    }

		    public override void Notify()
		    {
			    // called when the notify method on the super class observer is called
			    Console.WriteLine("I am observer B");
		    }
	    }    
    }
}


// Check over Week 11 slides.
// This will be requiring the Observer design pattern.