using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class BidderOne : IBidder
    {
        public int update(Object currentBid)
        {
            if (Convert.ToInt32(currentBid) < 300)
            {
                Console.WriteLine("BidderOne placing another bet");
                return Bid(20);
            }
            else
            {
                Console.WriteLine("bidder one: No more bets");
                return 0;
            }
        }

        public int Bid(int bid)
        {
            return bid;
        }
    }
}
