using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.I_Builder.Person
{
    internal class PersonFatBuilder : PersonBuilder
    {
        public override void BuildArmLeft()
        {
            Console.WriteLine("粗胳膊左");
        }

        public override void BuildArmRight()
        {
            Console.WriteLine("粗胳膊右");
        }

        public override void BuildBody()
        {
            Console.WriteLine("粗身体");
        }

        public override void BuildHead()
        {
            Console.WriteLine("粗脑袋");
        }

        public override void BuildLegLeft()
        {
            Console.WriteLine("粗腿左");
        }

        public override void BuildLegRight()
        {
            Console.WriteLine("粗腿右");
        }
    }
}