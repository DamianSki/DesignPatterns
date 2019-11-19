using DesignPatterns.MapComponents;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    abstract class MazeFactory
    {
        public abstract Maze MakeMaze();
        public abstract Room MakeRoom();
        public abstract Door MakeDoor(Room r1, Room r2);
        public abstract Wall MakeWall();
    }
}
