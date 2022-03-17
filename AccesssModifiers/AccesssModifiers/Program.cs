using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifierLibrary;

namespace AccesssModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            TestAccess.MethodToGet();

            //LibraryClass mylib = new LibraryClass();  //due to internal
           //mylib.LibraryMethod(8); //due to static this doesn't work
            //LibraryClass.LibraryMethod(9);
            OtherLibraryClass olc = new OtherLibraryClass();
            olc.AccessInternal(10);

            //---------------------------------------------------//
            int a = 655535;
            int b = 5;
            Console.WriteLine("Private Local Variables;  a = {0}, b = {1}", a, b);

            // Static Members (methods, properties, etc)
            // - not available to objects of parent class
            // -can access through name of parent class (if in scope)
            // -doesn't need any information about object instance

            double c = Math.Pow(a, b);
            Console.WriteLine("Private Local Variables;  c = {0}", c);
            // math m = new Math()
            // cannot create object of a stati class

            // static members of non-static classes can be accessed directly
            // as long as they are reachable by scope
            // As no object has been created, the instance constructor has not yet been run
            Console.WriteLine($"Value of static class member h = {SecondClass.h}");

            // after running the constructor
            SecondClass sc = new SecondClass();
            Console.WriteLine($"Value of static class member h = {SecondClass.h}");

            // attempting access through the class object shows that 'h' does not exist
            // sc.h --> does not exist
            sc.k = 115; // --> but this does!

            // Assining a value to h from the Program Classs
            SecondClass.h = a;
            Console.WriteLine($"Value of static class member h = {SecondClass.h}");
            // access 'h' from theird class
            Console.WriteLine("How ThirdClass sees h - ");
            ThirdClass.PrintFromThirdClass();

            // Access 'y' directly - Static Constructor has already happened
            Console.WriteLine("Static member y of non-static class = {0}", FourthClass.y);

            // Access 'y' after intantiation of class object
            FourthClass fc = new FourthClass();
            Console.WriteLine("Static member y of non-static class = {0}", FourthClass.y);

            // Static onstructor assigning value to static meber in static class
            // Access 'y' directly - Static Constructor has already happened
            Console.WriteLine("Static Constructor assignment to static member = {0}", FifthClass.d);


            Console.ReadKey();
        }
    }

    static class TestAccess
    {
        static public void MethodToGet()
        {

        }
    }

}
