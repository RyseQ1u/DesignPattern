using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.L_State.Works;

namespace DesignPattern.L_State.State
{
    internal class AfternoonState : AbsState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 18)
            {
                Console.WriteLine($"现在 {work.Hour}点,下午，还有精神。");
            }
            else
            {
                work.SetState(new EveningState());
                work.WriteProgram();
            }
        }
    }
}