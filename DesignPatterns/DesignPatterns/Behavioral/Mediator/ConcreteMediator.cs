namespace DesignPatterns.Behavioral.Mediator
{
    public class ConcreteMediator : IMediator
    {
        public ConcreteMediator(Component componentA, Component componentB)
        {
            _componentA = componentA;
            _componentB = componentB;
        }
        public readonly Component _componentA;
        public readonly Component _componentB;
        public void Notify(object sender, Actions action)
        {   
            switch(action)
            { 
                case Actions.C:
                    (_componentB as ConcreteComponentB).ActionC();
                    break;
                case Actions.A:
                    (_componentA as ConcreteComponentA).ActionA();
                    break;
                case Actions.D:                    
                    (_componentB as ConcreteComponentB).ActionC();
                    (_componentB as ConcreteComponentB).ActionD();
                    break;
            }                
        }
    }
}
