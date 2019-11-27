using DesignPatterns.MapComponents.Enums;
using System;

namespace DesignPatterns.MapComponents
{
    public class Room : MapSite, ICloneable
    {
        public Room(int n) { Initialize(n); }
        private int _n;
        public void Initialize(int n)
        {
            _n = n;
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
