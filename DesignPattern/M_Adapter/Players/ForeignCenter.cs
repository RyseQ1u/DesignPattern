using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.M_Adapter.Players
{
    internal class ForeignCenter
    {
        //public ForeignCenter(string name) : base(name)
        //{
        //}
        public string name { get; set; }

        public void 进攻()
        {
            Console.WriteLine($"中锋 {this.name} 正在进攻中");
        }

        public void 防守()
        {
            Console.WriteLine($"中锋 {this.name} 正在防守中");
        }
    }
}