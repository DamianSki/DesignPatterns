using DesignPatterns.MapComponents;
using DesignPatterns.MapComponents.Enums;

namespace DesignPatterns.CreationalPatterns.FactoryMethod
{
    public class MazeGame
    {
        public virtual Maze MakeMaze() => new Maze();
        public virtual Room MakeRoom(int n) => new Room(n);
        public virtual Wall MakeWall => new Wall();
        public virtual Door MakeDoor(Room r1, Room r2) => new Door(r1, r2);

        public virtual Maze CreateMaze()
        {
            var maze = new Maze();

            Room rl = MakeRoom(1);
            Room r2 = MakeRoom(2);
            Door theDoor = MakeDoor(rl, r2);

            maze.AddRoom(rl);
            maze.AddRoom(r2);

            rl.SetSide(DirectionEnum.North, MakeWall);
            rl.SetSide(DirectionEnum.East, theDoor);
            rl.SetSide(DirectionEnum.South, MakeWall);
            rl.SetSide(DirectionEnum.West, MakeWall);
            r2.SetSide(DirectionEnum.North, MakeWall);
            r2.SetSide(DirectionEnum.East, MakeWall);
            r2.SetSide(DirectionEnum.South, MakeWall);
            r2.SetSide(DirectionEnum.West, theDoor);

            return maze;
        }
    }
}
