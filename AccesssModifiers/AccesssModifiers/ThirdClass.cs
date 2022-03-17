using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesssModifiers
{
    class ThirdClass
    {
        private static double j = SecondClass.h;

        public static void PrintFromThirdClass()
        {
            Console.WriteLine("Static Member h from SecondClass = {0}" , j);
        }

    }
}
