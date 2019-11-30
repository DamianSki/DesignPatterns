using System;

namespace DesignPatterns.Behavioral.Strategy
{
    public class StrategyC : IStrategy
    {
        public void Algorithm() => Console.WriteLine(nameof(StrategyC));
    }
}
