using System;

namespace VisitorPattern
{
    public class Service
    {
        public Order GetOrder()
        {
            if (Random.Shared.Next() % 2 == 0)
            {
                return new OnlineOrder();
            }
            return new OfflineOrder();
        }
    }
}