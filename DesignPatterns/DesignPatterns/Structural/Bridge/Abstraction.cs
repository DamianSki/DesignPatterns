namespace DesignPatterns.Structural.Bridge
{
    public abstract class Abstraction
    {
        public Abstraction(Implementator implementator)
        {
            _implementator = implementator;
        }

        protected readonly Implementator _implementator;
        public abstract void Operation();
    }
}
