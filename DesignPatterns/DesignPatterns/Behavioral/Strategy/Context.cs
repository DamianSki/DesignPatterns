namespace DesignPatterns.Behavioral.Strategy
{
    public class Context
    {
        public Context(IStrategy strategy) => SetStrategy(strategy);
        private IStrategy _strategy;
        private void SetStrategy(IStrategy strategy) => _strategy = strategy;
    }
}
