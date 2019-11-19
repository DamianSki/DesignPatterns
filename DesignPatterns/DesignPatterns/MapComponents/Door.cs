using System;
using DesignPatterns.MapComponents.Enums;

namespace DesignPatterns.MapComponents
{
    public class Door : MapSite
    {
        private Room r1;
        private Room r2;

        public Door(Room r1, Room r2)
        {
            this.r1 = r1;
            this.r2 = r2;
        }

        public override void Enter()
        {
            throw new NotImplementedException();
        }

        public override MapSite GetSide(int direction)
        {
            throw new NotImplementedException();
        }
        
        public override void SetSide(DirectionEnum direction, MapSite site)
        {
            throw new NotImplementedException();
        }
    }
}
