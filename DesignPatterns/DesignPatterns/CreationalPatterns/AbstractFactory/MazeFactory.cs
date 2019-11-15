using DesignPatterns.CreationalPatterns.AbstractFactory.MapComponents;
using DesignPatterns.CreationalPatterns.AbstractFactory.MapComponents.EnchantedMaze;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    abstract class MazeFactory
    {
        public abstract Maze MakeMaze();
        public abstract Room MakeRoom();
        public abstract Door MakeDoor(Room r1, Room r2);
        public abstract Wall MakeWall();
    }

    class EnchantedMazeFactory : MazeFactory
    {
        public override Door MakeDoor(Room r1, Room r2)
        {
            return new MagicalDoor();
        }

        public override Maze MakeMaze()
        {
            return new Maze();
        }

        public override Room MakeRoom()
        {
            return new EnchantedRoom();
        }

        public override Wall MakeWall()
        {
            return new FireWall();
        }
    }
}
