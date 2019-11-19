using System;
using DesignPatterns.MapComponents.Enums;

namespace DesignPatterns.MapComponents
{
    public class Wall : MapSite
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
    }
}
