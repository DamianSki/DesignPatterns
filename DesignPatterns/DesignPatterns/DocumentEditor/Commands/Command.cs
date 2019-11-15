using System;

namespace DesignPatterns.DocumentEditor.Commands
{
    abstract class Command
    {
        protected object _state;

        public abstract void Execute();
    }
}