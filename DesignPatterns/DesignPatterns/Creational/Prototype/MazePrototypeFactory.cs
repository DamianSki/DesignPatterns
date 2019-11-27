using DesignPatterns.MapComponents;

namespace DesignPatterns.CreationalPatterns.Prototype
{
    public class MazePrototypeFactory : MazeFactory
    {
        public MazePrototypeFactory(Maze maze, Room room, Wall wall, Door door)
        {
            _maze = maze;
            _room = room;
            _wall = wall;
            _door = door;
        }

        private Maze _maze;
        private Room _room;
        private Wall _wall;
        private Door _door;

        public override Door MakeDoor(Room r1, Room r2)
        {
            var door = (Door)_door.Clone();
            door.Initialize(r1, r2);
            return door;   
        }

        public override Maze MakeMaze => (Maze)_maze.Clone();

        public override Room MakeRoom(int n)
        {
            var room = (Room)_room.Clone();
            room.Initialize(n);
            return room;
        }

        public override Wall MakeWall() => (Wall)_wall.Clone();
    }
}
