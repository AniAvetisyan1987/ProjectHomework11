using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHomework11
{
    internal class InheritanceParentClass :IFile
    {
        public string myStr;
        public InheritanceParentClass(string myStr)
        {
            this.myStr = myStr;
            Console.WriteLine("Parent Constructor.");
        }
        public void print()
        {
            Console.WriteLine("Parent Class.");
        }

        public void IFileRead()
        {
            Console.WriteLine(myStr);
        }
        public void IFileWrite()
        {
            myStr = "new MyString";
            Console.WriteLine(myStr);
        }
    }
}
