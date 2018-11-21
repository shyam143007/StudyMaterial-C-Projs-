namespace Console
{
    public class ChildClass : AbstractClass
    {
        public override int MyProperty { get; set; }

        public override void AbstractMethod()
        {
            System.Console.WriteLine("Abstract method implemented in child class");
        }

        public void ChildMethod()
        {
            System.Console.WriteLine("Child class method");
        }
    }
}
