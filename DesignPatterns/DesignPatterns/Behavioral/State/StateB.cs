namespace DesignPatterns.Behavioral.State
{
    public class StateB : State
    {
        public override void Handle(string request)
        {
            Print(request);
            _context.Transition(new StateA());
        }
    }
}
