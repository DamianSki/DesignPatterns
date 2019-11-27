using DesignPatterns.MapComponents;
using DesignPatterns.MapComponents.EnchantedMaze;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    public class EnchantedMazeFactory : MazeFactory
    {
        public EnchantedMazeFactory()
        {
        }

        public override Door MakeDoor(Room r1, Room r2)
        {
            return new MagicalDoor(r1, r2);
        }

        public override Maze MakeMaze()
        {
            return new Maze();
        }

        public override Room MakeRoom(int n)
        {
            return new EnchantedRoom(n);
        }

        public override Wall MakeWall()
        {
            return new FireWall();
        }
    }
}
