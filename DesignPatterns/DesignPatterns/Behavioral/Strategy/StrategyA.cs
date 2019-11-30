using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public class StrategyA : IStrategy
    {
        public void Algorithm() => Console.WriteLine(nameof(StrategyA));
    }
}
