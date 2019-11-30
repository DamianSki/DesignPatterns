namespace DesignPatterns.Behavioral.State
{
    public class Context
    {
        public Context() => Transition(new StateA());        
        private State _state;
        public void Transition(State state)
        {
            _state = state;
            _state.SetContext(this);
        }

        public void Handle(string request) => _state.Handle(request);
    }
}
