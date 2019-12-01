namespace DesignPatterns.Behavioral.Visitor
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
}
