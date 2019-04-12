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

		    public void NotifyAll(Bidder bidderInfo)
		    {
			    // for each observer, invoke the notify method
			    // on the given observer
			    foreach (var bidder in this.listOfBidders)
			    {
				    bidder.Notify();
			    }
		    }

            public void AddBidderToItem(Bidder observer)
            {
                //Making sure the maximum bids are less than 5
                if(bidderStack.Count < 5)
                {
                    //Pushes the bidder onto the stack
                    this.bidderStack.Push(observer);
                    
                    //Auctioneer announces the bidder
                    NotifyAll(observer);
                }
                else
                {
                    
                    var winner = this.bidderStack.Pop();
                    NotifyAll(winner);
                    RemoveObserver(winner.Name);
                }
            }
	    }
       

	    public class BidderFeatures : Bidder
	    {
		    public BidderFeatures(string name, double amountToBid, double bid, bool hasWon) : base(name, amountToBid, bid, hasWon)
		    {
                
		    }

		    public override void Notify()
		    {
			    if (HasWon)
                {
                    Console.WriteLine("Bidder: " + Name + " is declared the winner!" + Name + "is forced to leave...");
                }
                else
                {
                    Console.WriteLine("Bidder: " + Name + " has place a bid of " + Bid + " Dollars!");
                }

		    }
	    }
    }
}


// Check over Week 11 slides.
// This will be requiring the Observer design pattern.