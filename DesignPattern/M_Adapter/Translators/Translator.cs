using DesignPattern.M_Adapter.Players;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.M_Adapter.Translators
{
    internal class Translator : Player
    {
        private ForeignCenter fc = new ForeignCenter();

        public Translator(string name) : base(name)
        {
            fc.name = name;
        }

        public override void Attack()
        {
            fc.进攻();
        }

        public override void Defense()
        {
            fc.防守();
        }
    }
}