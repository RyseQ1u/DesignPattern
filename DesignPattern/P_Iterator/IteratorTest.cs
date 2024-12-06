using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.P_Iterator
{
    public class IteratorTest
    {
        public void Run()
        {
            var a = new ConcreteAggregate();
            a[0] = "a0";
            a[1] = "a1";
            a[2] = "a2";
            a[3] = "a3";
            a[4] = "a4";
            a[5] = "a5";
            var i = new ConcreteIterator(a);
            object item = i.First();
            while (!i.IsDone())
            {
                Console.WriteLine($"{i.CurrentItem()} do something...");
                i.Next();
            }
        }
    }
}