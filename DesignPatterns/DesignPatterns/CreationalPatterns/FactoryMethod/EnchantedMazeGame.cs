using DesignPatterns.MapComponents;
using DesignPatterns.MapComponents.EnchantedMaze;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class EnchantedMazeGame : MazeGame
    {
        public EnchantedMazeGame()
        {
        }

        public override Room MakeRoom(int n) => new EnchantedRoom(n);

        public override Door MakeDoor(Room rl, Room r2) => new MagicalDoor(rl, r2);
    }
}
