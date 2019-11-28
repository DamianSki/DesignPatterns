using System.Collections;

namespace DesignPatterns.Structural.Flyweight
{
    public class FlyweightFactory
    {
        public FlyweightFactory()
        {
            _flyweights.Add("a", new ConcreteFlyweight());
            _flyweights.Add("b", new ConcreteFlyweight());
            _flyweights.Add("c", new ConcreteFlyweight());
        }

        private Hashtable _flyweights = new Hashtable();

        public Flyweight GetFlyweight(string key)
        {
            return ((Flyweight)_flyweights[key]);
        }
    }
}
