namespace DesignPatterns.Structural.Facade
{
    public class Facade
    {
        public Facade(SubSystemA sysA, SubSystemB sysB)
        {
            _sysA = sysA;
            _sysB = sysB;
        }

        private readonly SubSystemA _sysA;
        private readonly SubSystemB _sysB;

        public void OperationA() => _sysA.Operation();
        public void OperationB() => _sysB.Operation();
    }
}
