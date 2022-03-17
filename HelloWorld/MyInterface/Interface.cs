using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyInterface
{
    public interface IPluginInterface
    {
        int a { get; set; }
        string Name { get; set; }
        void myMethod();
        void anotherMethod(int i);

    }
}
