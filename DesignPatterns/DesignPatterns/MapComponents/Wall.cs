﻿using System;

namespace DesignPatterns.MapComponents
{
    class Wall : MapSite
    {
        public override void Enter()
        {
            throw new NotImplementedException();
        }

        public override MapSite GetSide(int direction)
        {
            throw new NotImplementedException();
        }

        public override void SetSide(int direction, MapSite site)
        {
            throw new NotImplementedException();
        }
    }
}