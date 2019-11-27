using DesignPatterns.MapComponents;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    public abstract class MazeFactory
    {
        public abstract Maze MakeMaze { get; }

        public abstract Room MakeRoom(int n);
        public abstract Door MakeDoor(Room r1, Room r2);
        public abstract Wall MakeWall();
    }
}
