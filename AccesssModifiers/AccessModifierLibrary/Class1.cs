using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierLibrary
{
    internal class LibraryClass
    {
        static int x;
        static public void  LibraryMethod(int incoming)
        {
            x = incoming;
        }
    }

    public class OtherLibraryClass : ProtectedData
    {
        public void AccessInternal(int incoming)
        {
            LibraryClass.LibraryMethod(incoming);   
            //LibraryClass lc = new LibraryClass();
            //lc.LibraryMethod(incoming); 

        }

        public void AccessProtected()
        {
            ProtectedData pd = new ProtectedData();
            //pd.z = 0; // z can't be accesses
            OtherLibraryClass olc = new OtherLibraryClass();
            olc.z = 10; //direct access to z because it is added on the OtherLibraryClass
        }
    }

    public class ProtectedData
    {
        protected int z = 5;
    }
}
