using System;

namespace DesignPatterns.Structural.Proxy
{
    public class Proxy : ISubject
    {
        private ISubject _realSubject;

        public Proxy(ISubject realSubject)
        {
            _realSubject = realSubject;
        }
                
        public void Request()
        {
            if (CheckAccess())
            {
                _realSubject = new RealSubject();
                _realSubject.Request();

                LogAccess();
            }
        }

        public bool CheckAccess()
        {            
            Console.WriteLine("Checking access prior to firing a real request.");
            return true;
        }

        public void LogAccess()
        {
            Console.WriteLine("Logging the time of request.");
        }
    }
}
