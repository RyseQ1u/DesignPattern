using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.G_TemplateMethod.Paper;

namespace DesignPattern.G_TemplateMethod
{
    internal class TemplateMethodTest
    {
        public void Run()
        {
            TestPaper tA = new TestPaperA();
            tA.TestQuestion1();
            tA.TestQuestion2();
            tA.TestQuestion3();
            
            TestPaper tB = new TestPaperB();
            tB.TestQuestion1();
            tB.TestQuestion2();
            tB.TestQuestion3();
            Console.ReadLine();
        }
    }
}
