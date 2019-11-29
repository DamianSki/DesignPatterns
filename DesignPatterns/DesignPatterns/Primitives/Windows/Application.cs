using System.Collections.Generic;

namespace DesignPatterns.Primitives.Windows
{
    public class Application
    {
        IList<Document> _documents = new List<Document>();

        public void Add(Document document) => _documents.Add(document);
    }
}
