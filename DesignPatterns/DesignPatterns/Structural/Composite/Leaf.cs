using System;

namespace DesignPatterns.Structural.Composite
{
    public class Leaf : Component
    {
        public override void Operation()
        {
            throw new System.NotImplementedException();
        }

        public override void Add(Component component)
        {
            throw new InvalidOperationException();
        }

        public override void Remove(Component component)
        {
            throw new InvalidOperationException();
        }

        public override Component GetChild(int id)
        {
            throw new InvalidOperationException();
        }
    }
}
