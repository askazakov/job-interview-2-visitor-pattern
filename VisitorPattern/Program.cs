using System;
using System.Linq;

namespace VisitorPattern
{
    public class DbConnection
    {
    }

    public class DbConnectionVisitor : IVisitor
    {
        private readonly DbConnection _dbConnection;

        public DbConnectionVisitor(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public void AddOrder(OnlineOrder order)
        {
            Console.WriteLine("Online order added");
        }

        public void AddOrder(OfflineOrder order)
        {
            Console.WriteLine("Offline order added");
        }
    }


    public static class Program
    {
        public static void Main()
        {
            var dbConnection = new DbConnection();
            var service = new Service();
            var visitor = new DbConnectionVisitor(dbConnection);

            foreach (var _ in Enumerable.Range(0, 10))
            {
                var order = service.GetOrder();
                order.Accept(visitor);
            }
        }
    }
}