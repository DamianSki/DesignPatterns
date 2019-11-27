using DesignPatterns.MapComponents.Enums;
using System;

namespace DesignPatterns.MapComponents
{
    public class Door : MapSite, ICloneable
    {
        private Room _r1;
        private Room _r2;

        public Door(Room r1, Room r2) => Initialize(r1, r2);

        public void Initialize(Room r1, Room r2)
        {
            _r1 = r1;
            _r2 = r2;
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
        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
