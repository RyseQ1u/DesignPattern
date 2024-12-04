using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.N_Composite.Compoents
{
    /// <summary>
    /// 支节点
    /// </summary>
    internal class Composite : Compoent
    {
        private List<Compoent> children = new();

        public Composite(string name) : base(name)
        {
        }

        public override void Add(Compoent c)
        {
            children.Add(c);
        }

        public override void Dispaly(int deepth)
        {
            Console.WriteLine(new string('-', deepth) + name);
            foreach (Compoent c in children)
            {
                c.Dispaly(deepth + 2);
            }
        }

        public override void Remove(Compoent c)
        {
            children.Remove(c);
        }
    }
}