namespace DesignPatterns.Structural.Decorator
{
    public class ConcreteDecoratorA : Decorator
    {
        public ConcreteDecoratorA(Component component) : base(component) { }
        public override void Operation()
        {
            throw new System.NotImplementedException();
        }
    }
}
