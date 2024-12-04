using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.N_Composite.Compoents
{
    internal abstract class Compoent
    {
        public string name { get; set; }

        public Compoent(string name)
        {
            this.name = name;
        }

        public abstract void Add(Compoent c);

        public abstract void Remove(Compoent c);

        public abstract void Dispaly(int deepth);
    }
}