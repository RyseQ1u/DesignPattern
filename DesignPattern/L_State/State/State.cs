using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.L_State.State
{
    abstract class State
    {
        public abstract void Handle(Context conText);
    }
}