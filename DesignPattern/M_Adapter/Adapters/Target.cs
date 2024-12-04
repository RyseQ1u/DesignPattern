using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.M_Adapter.Adapters
{
    internal class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求！");
        }
    }
}