using System;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    public sealed class MazeFactory
    {
        private MazeFactory() { }

        private static readonly Lazy<MazeFactory> _instance = new Lazy<MazeFactory>(() => new MazeFactory(), System.Threading.LazyThreadSafetyMode.PublicationOnly);
        public static MazeFactory Instance => _instance.Value;
    }
}
