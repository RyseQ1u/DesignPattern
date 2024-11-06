using DesignPattern.C_Decorato.Dcorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.C_Decorator.ConcreteDecorator
{
    public class TShirts : Finery
    {
        public override void Show()
        {
            Console.Write("大T恤");
            base.Show();
        }
    }

    public class BigTrouser : Finery
    {
        public override void Show()
        {
            Console.Write("垮裤");
            base.Show();
        }
    }

    public class Sneakers : Finery
    {
        public override void Show()
        {
            Console.Write("破球鞋");
            base.Show();
        }
    }
}