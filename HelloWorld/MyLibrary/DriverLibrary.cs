using System;
using MyInterface;

namespace MyLibrary
{
    public class DriverLibrary : IPluginInterface
    {
        public int a { get; set; }
        public string Name { get; set; }
        public DriverLibrary() //cunstructor
        {
            Console.WriteLine("Library instantiated");
        }

        public void myMethod()
        {
            if (this.Name.Length > 1)
            {
                Console.WriteLine($"Library field name contains {this.Name}");
            }
            else
            {
                Console.WriteLine("Library field name is currently empty");
            }
        }
        public void anotherMethod(int i)
        {
            Console.WriteLine($"anotherMethod was send {i} plus field a added the answer is {i+this.a}");
        }
    }
}
