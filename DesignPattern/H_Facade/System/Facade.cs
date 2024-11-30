using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.H_Facade.System
{
    internal class Facade
    {
        SubSystem1 SubSystem1;
        SubSystem2 SubSystem2;
        SubSystem3 SubSystem3;
        SubSystem4 SubSystem4;

        public Facade()
        {
            SubSystem1 = new SubSystem1();
            SubSystem2 = new SubSystem2();
            SubSystem3 = new SubSystem3();
            SubSystem4 = new SubSystem4();
        }

        public void Method1()
        {
            SubSystem1.Method1();
            SubSystem2.Method2();
            SubSystem3.Method3();
        }

        public void Method2()
        {
            SubSystem2.Method2();
            SubSystem3.Method3();
            SubSystem4.Method4();
        }
    }
}
