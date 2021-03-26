using System;

namespace VisitorPattern
{
    public class Service
    {
        private readonly Random _random = new(42);

        public Order GetOrder()
        {
            if (_random.Next() % 2 == 0)
            {
                return new OnlineOrder();
            }
            return new OfflineOrder();
        }
    }
}