namespace DesignPatterns.Structural.Bridge
{
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementator implementator) : base(implementator) { }

        public override void Operation()
        {
            throw new System.NotImplementedException();
        }
    }
}
