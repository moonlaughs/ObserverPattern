using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IBidder
    {
        public int update(Object obj);
        public int Bid(int bid);
    }
}
