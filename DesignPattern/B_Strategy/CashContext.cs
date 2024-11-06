using DesignPattern.B_Strategy.CashStrategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.B_Strategy
{
    /// <summary>
    /// 策略+简单工厂实现
    /// </summary>
    public abstract class CashContext
    {
        private CashSuper cs;

        public CashContext(string type)
        {
            switch (type)
            {
                case "正常收费":
                    cs = new CashNormal();
                    break;

                case "满300 减50":
                    cs = new CashReturn("300", "50");
                    break;

                case "7.9折":
                    cs = new CashRebate("0.79");
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cs.AcceptCash(money);
        }
    }
}