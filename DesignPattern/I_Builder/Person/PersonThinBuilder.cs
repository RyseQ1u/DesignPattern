using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.I_Builder.Person
{
    internal class PersonThinBuilder : PersonBuilder
    {
        public override void BuildArmLeft()
        {
            Console.WriteLine("细胳膊左");
        }

        public override void BuildArmRight()
        {
            Console.WriteLine("细胳膊右");
        }

        public override void BuildBody()
        {
            Console.WriteLine("细身体");
        }

        public override void BuildHead()
        {
            Console.WriteLine("细脑袋");
        }

        public override void BuildLegLeft()
        {
            Console.WriteLine("细腿左");
        }

        public override void BuildLegRight()
        {
            Console.WriteLine("细腿右");
        }
    }
}