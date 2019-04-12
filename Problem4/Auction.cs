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
            ///  Adds an observer to the list of bidders
            /// </summary>
            /// <param name="observer"></param>
		    public void AddObserver(Bidder observer)
		    {
			    // only add the observer
			    // if there is no observer already added with the given name
			    if (this.listOfBidders.All(c => c.Name != observer.Name))
			    {
                    //Adds new bidder to the list
				    this.listOfBidders.Add(observer);
			    }

		    }

		    public void RemoveObserver(string name)
		    {
			    // remove all the observers from the list
			    // where the name of the observer matches the name provided
			    this.listOfBidders.RemoveAll(c => c.Name == name);
		    }

            /// <summary>
            /// This notify is for the announcement of bidder on an item
            /// </summary>
            /// <param name="bidderInfo"></param>
		    public void NotifyAll(Bidder bidderInfo)
		    {
			    // for each observer, invoke the notify method
			    // on the given observer
			    foreach (var bidder in this.listOfBidders)
			    {
				    bidder.Notify();
			    }
		    }

            /// <summary>
            ///  This notify is for the announcement of item
            /// </summary>
            /// <param name="itemInfo"></param>
            public void NotifyAll(Item itemInfo)
            {
                // for each observer, invoke the notify method
                // on the given observer
                foreach (var bidder in this.listOfBidders)
                {
                    bidder.Notify();
                }
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="observer"></param>
            public void AddBidderToItem(Bidder observer)
            {
                //Making sure the maximum bids are less than 5
                if(bidderStack.Count < 5)
                {
                    //If the current bidder bid's higher than the previous bidder on the stack
                    //And the current bidder has a sufficient amount to bid
                    //Only then make a successful bid
                    if(observer.Bid > bidderStack.Peek().Bid && observer.AmountToBid > observer.Bid)
                    {
                        //Pushes the bidder onto the stack
                        this.bidderStack.Push(observer);
                        
                        //Auctioneer announces the bidder
                        NotifyAll(observer);
                    }
                    else
                    {
                        throw new InvalidOperationException("The bidder does not the required amount to bid.");
                    }
                }
                else
                {
                    //Gets the winner off the stack
                    var winner = this.bidderStack.Pop();
                    //Sets the winner to has Won
                    winner.HasWon = true;
                    //Clears the rest of the bidders off the stack
                    bidderStack.Clear();
                    //Notifies all the bidders the winner of the item
                    NotifyAll(winner);
                    //Removes the winner from the auction completely
                    RemoveObserver(winner.Name);
                }
            }

            /// <summary>
            /// The purpose is to announce when a new item is for auction
            /// </summary>
            /// <param name="item">Passes in details of an item</param>
            public void AnnounceItem(Item item)
            {
                item.IsNew = true;
                NotifyAll(item);
            }
	    }
       
        /// <summary>
        /// This subclass of observer or "Bidder" includes the features within a bidder
        /// And Notifies when a bidder has won or bid over another bidder
        /// </summary>
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

        public class ItemFeatures : Item
        {
            public ItemFeatures(string name, double price, DateTimeOffset yearOfCreation, bool isNew) : base(name, price, yearOfCreation, isNew)
            {

            }

            public override void Notify()
            {
                if (IsNew)
                {
                    Console.WriteLine("The item on auction today is " + Name + ", created in the year " + YearOfCreation + " and the starting price is" + Price);
                }
            }
        }
    }
}


// Check over Week 11 slides.
// This will be requiring the Observer design pattern.