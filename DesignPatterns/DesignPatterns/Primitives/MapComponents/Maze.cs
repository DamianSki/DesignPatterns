using System;

namespace DesignPatterns.MapComponents
{
    public class Maze : ICloneable
    {
        public void AddRoom(MapSite site)
        {
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public Room RoomNo(int n)
        {
            throw new NotImplementedException();
        }
    }
}
