using DesignPatterns.MapComponents;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public abstract class MazeFactory
    {
        public abstract Maze MakeMaze();
        public abstract Room MakeRoom(int n);
        public abstract Door MakeDoor(Room r1, Room r2);
        public abstract Wall MakeWall();
    }
}
