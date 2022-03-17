using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesssModifiers
{
    class SecondClass
    {

        public int k;
        public static double h;

        public SecondClass()
        {
            h = DoMath(3);
        }

        double DoMath (int inoming)
        {
            return Math.Pow(inoming, inoming);

        }

    }
}
