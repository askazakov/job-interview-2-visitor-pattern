namespace VisitorPattern
{
    public abstract class Order
    {
        public abstract void Accept(IVisitor visitor);
    }

    public class OnlineOrder : Order
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.AddOrder(this);
        }
    }

    public class OfflineOrder : Order
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.AddOrder(this);
        }
    }
}