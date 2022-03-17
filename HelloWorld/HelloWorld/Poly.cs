using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{


    class BaseDisplay  // parent classs
    {
        public string Name { get; set; }
        public virtual void PowerOn(string device)
        {
            Console.WriteLine($"Sending PowerOn command for {device}");

        }
    }

    class Projector : BaseDisplay
    {
        public override void PowerOn(string device)
        {
            Console.WriteLine($"Sending PowerOn command for {device}");
            Console.WriteLine($"Sending lamp query command for {device}");
        }
    }

    class TvDisplay : BaseDisplay
    {

    }

    class Shapes
    {
        public class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Base object draw.");
            }
        }
        public class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Circle draw.");
            }
        }
        public class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Rectangle draw.");
            }
        }
    }
}
