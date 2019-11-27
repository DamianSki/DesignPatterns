using DesignPatterns.MapComponents;
using DesignPatterns.MapComponents.BombedMaze;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class BombedMazeGame : MazeGame
    {
        public override Wall MakeWall => new BombedWall();
        public override Room MakeRoom(int n) => new RoomWithABomb(n);
    }
}
