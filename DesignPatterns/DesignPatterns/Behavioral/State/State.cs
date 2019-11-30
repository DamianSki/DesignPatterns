using System;

namespace DesignPatterns.Behavioral.State
{
    public abstract class State 
    {
        protected Context _context;
        public virtual void SetContext(Context context) => _context = context;
        public abstract void Handle(string request);

        protected void Print(string request) => Console.WriteLine($"State: {GetType().Name}, request: {request}");
    }
}
