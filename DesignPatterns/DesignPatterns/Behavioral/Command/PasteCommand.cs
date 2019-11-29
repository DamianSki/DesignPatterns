using DesignPatterns.Primitives.Windows;

namespace DesignPatterns.Behavioral.Command
{
    public class PasteCommand : ICommand
    {
        public PasteCommand(Document document) => _document = document;

        private readonly Document _document;

        public void Execute(object request) => _document.Paste();
    }
}
