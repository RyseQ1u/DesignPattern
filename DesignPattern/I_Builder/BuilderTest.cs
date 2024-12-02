using DesignPattern.I_Builder.Director;
using DesignPattern.I_Builder.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.I_Builder
{
    internal class BuilderTest
    {
        public void Run()
        {
            var ptb = new PersonThinBuilder();
            var pdt = new PersonDirector(ptb);
            pdt.CreatePerson();
            Console.WriteLine();
            var pfb = new PersonFatBuilder();
            var pdf = new PersonDirector(pfb);
            pdf.CreatePerson();
        }
    }
}