using DesignPatterns.MapComponents.Enums;

namespace DesignPatterns.MapComponents
{
    public abstract class MapSite
    {
        public abstract MapSite GetSide(int direction);
        public abstract void SetSide(DirectionEnum direction, MapSite site);
        public abstract void Enter();
    }
}
