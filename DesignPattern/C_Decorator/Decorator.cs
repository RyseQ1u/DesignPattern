using DesignPattern.C_Decorator.CncreteComponent;
using DesignPattern.C_Decorator.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.C_Decorator
{
    public static class Decorator
    {
        public static void Test()
        {
            Man xc = new Man("小明");
            Console.WriteLine("第一种装扮：");
            Sneakers pqx = new Sneakers();
            BigTrouser kk = new BigTrouser();
            TShirts dtx = new TShirts();

            //装饰过程
            pqx.Decorate(xc);
            kk.Decorate(pqx);
            dtx.Decorate(kk);
            dtx.Show();

            Console.Read();
        }
    }
}