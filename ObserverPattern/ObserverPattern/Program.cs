using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer pattern");
            Console.WriteLine("=================");
            IBidder bidderOne = new BidderOne();
            IBidder bidderTwo = new BidderTwo();

            AuctionItem ai = new AuctionItem(100);
            ai.AcceptBidder(bidderOne);
            ai.AcceptBidder(bidderTwo);

            ai.GetCurrentHighBid();
            //ai.SetCurrentHighBid(bidderOne.);
            ai.GetCurrentHighBid();
            //ai.SetCurrentHighBid(bidderTwo.Bid(30));
            ai.GetCurrentHighBid();
            //ai.SetCurrentHighBid(bidderOne.Bid(10));
            ai.GetCurrentHighBid();
            //ai.SetCurrentHighBid(bidderTwo.Bid(30));
            ai.GetCurrentHighBid();
        }
    }
}
