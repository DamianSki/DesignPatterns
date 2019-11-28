using System;

namespace DesignPatterns.Structural.Proxy
{
    public class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("Real subject got request!");
        }
    }
}
