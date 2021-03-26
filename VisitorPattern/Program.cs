using System;
using System.Linq;

namespace VisitorPattern
{
    public class DbConnection
    {
    }

    public static class Program
    {
        private static void AddOnlineOrder(OnlineOrder order, DbConnection dbConnection)
        {
            Console.WriteLine("Online order added");
        }

        private static void AddOfflineOrder(OfflineOrder order, DbConnection dbConnection)
        {
            Console.WriteLine("Offline order added");
        }

        public static void Main()
        {
            var dbConnection = new DbConnection();
            var service = new Service();
            foreach (var _ in Enumerable.Range(0, 10))
            {
                var order = service.GetOrder();
                if (order.GetType().Name == "OnlineOrder")
                {
                    AddOnlineOrder((OnlineOrder) order, dbConnection);
                }
                else
                {
                    AddOfflineOrder((OfflineOrder) order, dbConnection);
                }
            }
        }
    }
}