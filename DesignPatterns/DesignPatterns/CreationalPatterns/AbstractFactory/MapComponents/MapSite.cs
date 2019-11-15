namespace DesignPatterns.CreationalPatterns.AbstractFactory.MapComponents
{
    abstract class MapSite
    {
        public abstract MapSite GetSide(int direction);
        public abstract void SetSide(int direction, MapSite site);
        public abstract void Enter();
    }
}
