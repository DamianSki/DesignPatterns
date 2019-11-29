namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    public abstract class Handler
    {
        public Handler(Handler successor, Topic topic)
        {
            _successor = successor;
            _topic = topic;
        }

        private readonly Handler _successor;
        private readonly Topic _topic;

        public virtual void HandleRequest(object request, Topic topic)
        {
            if (topic == _topic)
            {
                Handle(request);
                return;
            }

            _successor?.HandleRequest(request, topic);
        }
        public abstract void Handle(object request);
    }
}
