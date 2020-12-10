using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class AuctionItem : IAuctionItem
    {
        private List<IBidder> bidders;
        private int currentBid;

        public AuctionItem(int currentBid)
        {
            bidders = new List<IBidder>();
            this.currentBid = currentBid;
        }

        public void AcceptBidder(IBidder bidder)
        {
            bidders.Add(bidder);

        }

        public void RemoveBidder(IBidder bidder)
        {
            bidders.Remove(bidder);
        }

        public void GetCurrentHighBid()
        {
            Console.WriteLine("Current bid: " + currentBid);
            foreach(IBidder item in bidders)
            {
                SetCurrentHighBid(item.update(currentBid));
            }
        }

        public void SetCurrentHighBid(int additionalBid)
        {
            currentBid += additionalBid;
            Console.WriteLine("Updated bid: " + currentBid);
        }
    }
}
