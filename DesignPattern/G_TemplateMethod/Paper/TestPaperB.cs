using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.G_TemplateMethod.Paper
{
    internal class TestPaperB : TestPaper
    {
        protected override string A1()
        {
            return "c";
        }

        protected override string A2()
        {
            return "a";
        }

        protected override string A3()
        {
            return "a";
        }
    }
}
