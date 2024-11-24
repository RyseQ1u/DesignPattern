using DesignPattern.D_Proxy.BePursued;
using DesignPattern.D_Proxy.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.D_Proxy
{
    public static class ProxyTest
    {
        public static void Run()
        {
            Girl jiaojiao = new Girl();
            jiaojiao.Name = "李娇娇";
            PursuitProxy daili = new PursuitProxy(jiaojiao);
            daili.GiveDolls();
            daili.GiveFlowers();
            daili.GiveChocolate();
            Console.Read();
        }
    }
}