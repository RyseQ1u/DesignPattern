using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.G_TemplateMethod.Paper
{
    internal class TestPaper
    {
        public void TestQuestion1()
        {
            Console.WriteLine("Q1");
            Console.WriteLine($"A1：{A1()}");
        }
        public void TestQuestion2()
        {
            Console.WriteLine("Q2");
            Console.WriteLine($"A2：{A2()}");
        }
        public void TestQuestion3()
        {
            Console.WriteLine("Q3");
            Console.WriteLine($"A3：{A3()}");
        }

        protected virtual string A1()
        {
            return string.Empty;
        }
        protected virtual string A2()
        {
            return string.Empty;
        }
        protected virtual string A3()
        {
            return string.Empty;
        }
    }
}
