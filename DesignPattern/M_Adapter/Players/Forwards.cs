using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.M_Adapter.Players
{
    internal class Forwards : Player
    {
        public Forwards(string name) : base(name)
        {
        }

        public override void Attack()
        {
            Console.WriteLine($"前锋 {this.name} 正在进攻");
        }

        public override void Defense()
        {
            Console.WriteLine($"前锋 {this.name} 正在防守");
        }
    }
}