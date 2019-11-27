using DesignPatterns.MapComponents;
using DesignPatterns.MapComponents.Enums;

namespace DesignPatterns.CreationalPatterns.Builder
{
    public class StandardMazeBuilder : MazeBuilder
    {
        private Maze _maze;
        public override void BuildMaze()
        {
            _maze = new Maze();
        }
        public override Maze Maze => _maze;

        public override void BuildRoom(int n)
        {
            if (_maze.RoomNo(n) != null)
            {
                var room = new Room(n);
                _maze.AddRoom(room);

                room.SetSide(DirectionEnum.North, new Wall());
                room.SetSide(DirectionEnum.South, new Wall());
                room.SetSide(DirectionEnum.East, new Wall());
                room.SetSide(DirectionEnum.West, new Wall());
            }
        }
        public override void BuildDoor(int roomFrom, int roomTo)
        {
            Room r1 = _maze.RoomNo(roomFrom);
            Room r2 = _maze.RoomNo(roomTo);

            Door door = new Door(r1, r2);

            r1.SetSide(CommonWall(r1, r2), door);
            r2.SetSide(CommonWall(r2, r1), door);
        }
        private DirectionEnum CommonWall(Room r1, Room r2)
        {
            return DirectionEnum.East;
        }
    }
}
