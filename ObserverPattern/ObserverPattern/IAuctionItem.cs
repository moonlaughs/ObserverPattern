using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IAuctionItem
    {
        public void AcceptBidder(IBidder bidder);
        public void RemoveBidder(IBidder bidder);
        public void GetCurrentHighBid();
        public void SetCurrentHighBid(int additionalBid);
    }
}
