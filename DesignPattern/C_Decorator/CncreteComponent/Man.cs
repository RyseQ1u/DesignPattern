using DesignPattern.C_Decorator.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPattern.C_Decorator.CncreteComponent
{
    public class Man : Person
    {
        private string name;

        public Man()
        {
        }

        public Man(string name)
        {
            this.name = name;
        }

        public override void Show()
        {
            Console.WriteLine($"装扮的{name}先生");
        }
    }
}