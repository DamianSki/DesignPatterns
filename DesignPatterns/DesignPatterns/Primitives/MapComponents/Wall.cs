using DesignPatterns.MapComponents.Enums;
using System;

namespace DesignPatterns.MapComponents
{
    public class Wall : MapSite, ICloneable
    {
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
