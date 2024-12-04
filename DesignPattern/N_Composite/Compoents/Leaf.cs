using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.N_Composite.Compoents
{
    internal class Leaf : Compoent
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Compoent c)
        {
            Console.WriteLine("Cannot Add");
        }

        public override void Dispaly(int deepth)
        {
            Console.WriteLine(new string('-', deepth) + name);
        }

        public override void Remove(Compoent c)
        {
            Console.WriteLine("Cannot Remove");
        }
    }
}