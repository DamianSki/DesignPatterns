namespace DesignPatterns.Structural.Decorator
{
    public abstract class Decorator : Component
    {
        public Decorator(Component component)
        {
            _component = component;
        }

        protected readonly Component _component;
    }
}
