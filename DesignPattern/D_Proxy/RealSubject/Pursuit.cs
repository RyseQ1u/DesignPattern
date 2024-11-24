using DesignPattern.D_Proxy.BePursued;
using DesignPattern.D_Proxy.Proxy;
using DesignPattern.D_Proxy.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPattern.D_Proxy.RealSubject
{
    public class Pursuit : GiveGift
    {
        private Girl mm;

        public Pursuit(Girl mm)
        {
            this.mm = mm;
        }

        public void GiveChocolate()
        {
            Console.WriteLine($"{mm.Name}，送你巧克力");
        }

        public void GiveDolls()
        {
            Console.WriteLine($"{mm.Name}，送你玩偶");
        }

        public void GiveFlowers()
        {
            Console.WriteLine($"{mm.Name}，送你花");
        }
    }
}