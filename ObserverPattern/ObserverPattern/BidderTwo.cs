using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class BidderTwo : IBidder
    {
        public int update(Object currentBid)
        {
            if(Convert.ToInt32(currentBid) < 200)
            {
                Console.WriteLine("BidderTwo placing another bet");
                return Bid(30);
            }
            else
            {
                Console.WriteLine("bidder two: No more bets");
                return 0;
            }
        }
        public int Bid(int bid)
        {
            return bid;
        }
    }
}
