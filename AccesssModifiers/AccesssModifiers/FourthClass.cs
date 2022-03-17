using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesssModifiers
{
    class FourthClass
    {
        static public int y;

        // Static Constructor happens before Instance Constructor
        static FourthClass()
        {
            y = 72;
        }

        // Instamce Constructor only runs when an object is created of the class
        public FourthClass()
        {
            y = 55;
        }

    }

    static class FifthClass
    {
        public static int d;
        //public FifthClass() { } // Instance Constructor not allowed

        static FifthClass()
        {
            d = 12345;
        }
    }
}
