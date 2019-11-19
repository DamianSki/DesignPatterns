using DesignPatterns.MapComponents;
using DesignPatterns.MapComponents.EnchantedMaze;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
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
