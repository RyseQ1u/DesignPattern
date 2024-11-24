using DesignPattern.D_Proxy.BePursued;
using DesignPattern.D_Proxy.RealSubject;
using DesignPattern.D_Proxy.Subject;

namespace DesignPattern.D_Proxy.Proxy
{
    public class PursuitProxy : GiveGift
    {
        private Pursuit gg;

        public PursuitProxy(Girl mm)
        {
            gg = new Pursuit(mm);
        }

        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }

        public void GiveDolls()
        {
            gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }
    }
}