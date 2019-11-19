using DesignPatterns.MapComponents;

namespace DesignPatterns.CreationalPatterns.Builder
{
    class MazeGame
    {
        private readonly MazeBuilder _builder;

        public MazeGame(MazeBuilder builder)
        {
            _builder = builder;
        }

        public Maze CreateMaze()
        {
            _builder.BuildMaze();
            _builder.BuildRoom(1);
            _builder.BuildRoom(2);
            _builder.BuildDoor(1, 2);

            return _builder.Maze;
        }
    }
}
