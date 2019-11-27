namespace DesignPatterns.Structural.Decorator
{
    public class ConcreteDecoratorB : Decorator
    {
        public ConcreteDecoratorB(Component component) : base(component)
        {

        }

        public override void Operation()
        {
            throw new System.NotImplementedException();
        }
    }
}