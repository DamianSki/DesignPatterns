using System;

namespace DesignPatterns.DocumentEditor.Components.Commands
{
    abstract class Command
    {
        protected Object _state;

        public abstract void Execute();
    }
}