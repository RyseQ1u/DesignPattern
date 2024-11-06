using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.B_Strategy.CashStrategy
{
    /// <summary>
    /// 打折收费类
    /// </summary>
    public class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;

        /// <summary>
        /// 折扣
        /// </summary>
        /// <param name="moneyRebate"></param>
        public CashRebate(string moneyRebate)
        {
            this.moneyRebate = double.Parse(moneyRebate);
        }

        public override double AcceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}