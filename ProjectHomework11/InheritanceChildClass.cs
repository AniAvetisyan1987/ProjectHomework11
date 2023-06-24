namespace ProjectHomework11
{
    internal class InheritanceChildClass:InheritanceParentClass
    {
        public InheritanceChildClass(string str) :base(str) 
        {
            Console.WriteLine("Child Constructor.");
        }
    }
}
