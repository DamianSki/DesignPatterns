using DesignPatterns.Primitives.Windows;

namespace DesignPatterns.Behavioral.Command
{
    public class OpenCommand : ICommand
    {
        public OpenCommand(Document document) => _document = document;

        private readonly Document _document;

        public void Execute(object request) => _document.Open();
    }
}
