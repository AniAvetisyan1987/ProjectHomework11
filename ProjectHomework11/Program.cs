using ProjectHomework11;

internal class Program
{
    private static void Main(string[] args)
    {
        EncapsulationClass inst = new EncapsulationClass();
        Console.WriteLine( inst.Number = 12);
        Console.WriteLine(inst.showPrivateNum());

        //Interface instance
        InheritanceParentClass myParent = new InheritanceParentClass("Parent interface myString");
        myParent.IFileWrite();

        InheritanceChildClass child = new InheritanceChildClass("Child my string");
        child.print();

       
    }
}