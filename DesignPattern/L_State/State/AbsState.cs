using DesignPattern.L_State.Works;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.L_State.State
{
    abstract class AbsState
    {
        public abstract void WriteProgram(Work work);
    }
}