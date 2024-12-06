using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.P_Iterator
{
    public abstract class Aggregate
    {
        public abstract Iterator GetIterator();
    }
}