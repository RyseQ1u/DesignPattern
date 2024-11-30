using DesignPattern.H_Facade.Stock;
using DesignPattern.H_Facade.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.H_Facade
{
    internal class FacadeTest
    {
        void Run()
        {
            var jijing = new Fund();
            jijing.Buy();
            jijing.Sell();

        }

        void Run2()
        {
            var facade = new Facade();
            facade.Method1();
            facade.Method2();

        }
    }
}
