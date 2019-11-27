namespace DesignPatterns.Structural.Composite
{
    public class Composite : Component
    {
        public override void Operation()
        {
            throw new System.NotImplementedException();
        }

        public override void Add(Component component)
        {
            base.Add(component);
        }

        public override Component GetChild(int id)
        {
            base.GetChild(id);
        }

        public override void Remove(Component component)
        {
            base.Remove(component);
        }
    }
}
