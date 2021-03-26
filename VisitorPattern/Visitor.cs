namespace VisitorPattern
{
    public interface IVisitor
    {
        void AddOrder(OnlineOrder order);
        void AddOrder(OfflineOrder order);
        void AddOrder(AnotherTypeOrder order);
    }
}