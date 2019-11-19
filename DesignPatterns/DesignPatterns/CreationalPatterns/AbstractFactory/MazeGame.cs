using DesignPatterns.MapComponents;

namespace DesignPatterns.CreationalPatterns.AbstractFactory
{
    class MazeGame
    {
        public void CreateMaze(MazeFactory factory)
        {
            Maze maze = factory.MakeMaze();
            Room r1 = factory.MakeRoom(1);
            Room r2 = factory.MakeRoom(2);

            factory.MakeDoor(r1, r2);

            maze.AddRoom(r1);
            maze.AddRoom(r2);
        }
    }
}
