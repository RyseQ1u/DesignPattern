using DesignPattern.L_State.Works;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.L_State.State
{
    internal class RestState : AbsState
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine($"现在 {work.Hour}点,下班了。");
        }
    }
}