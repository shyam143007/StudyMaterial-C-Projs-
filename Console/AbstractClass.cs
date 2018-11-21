namespace Console
{
    public abstract class AbstractClass
    {
        public abstract int MyProperty { get; set; }
        public abstract void AbstractMethod();
        public virtual void VirtualMethod()
        {
            System.Console.WriteLine("I am Virtual");
        }
    }
}
