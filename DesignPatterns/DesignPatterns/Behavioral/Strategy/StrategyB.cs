using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public class StrategyB : IStrategy
    {
        public void Algorithm() => Console.WriteLine(nameof(StrategyB));
    }
}
