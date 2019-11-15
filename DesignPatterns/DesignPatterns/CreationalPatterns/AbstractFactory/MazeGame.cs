using DesignPatterns.CreationalPatterns.AbstractFactory.MapComponents;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    class MazeGame
    {
        public void CreateMaze(MazeFactory factory) {
            Maze maze = factory.MakeMaze();
            Room r1 = factory.MakeRoom();
            Room r2 = factory.MakeRoom();

            factory.MakeDoor(r1, r2);

            maze.AddRoom(r1);
            maze.AddRoom(r2);
        }
    }
}
