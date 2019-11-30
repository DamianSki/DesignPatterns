namespace DesignPatterns.Behavioral.State
{
    public class StateA : State
    {
        public override void Handle(string request)
        {
            Print(request);
            _context.Transition(new StateB());
        }
    }
}
