using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.N_Composite.Companys
{
    internal class ConcreteCompany : Company
    {
        private List<Company> children = new();

        public ConcreteCompany(string name) : base(name)
        {
        }

        public override void Add(Company c)
        {
            children.Add(c);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            foreach (Company c in children)
            {
                c.Display(depth + 2);
            }
        }

        public override void LineOfDuty()
        {
            foreach (Company c in children)
            {
                c.LineOfDuty();
            }
        }

        public override void Remove(Company c)
        {
            children.Remove(c);
        }
    }
}