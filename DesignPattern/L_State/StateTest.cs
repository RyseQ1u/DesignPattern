using DesignPattern.L_State.State;
using DesignPattern.L_State.Works;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.L_State
{
    internal class StateTest
    {
        public void Run()
        {
            #region V1

            //var hardWork = new Work();
            //hardWork.Hour = 8;
            //hardWork.WriteProgram();
            //hardWork.Hour = 10;
            //hardWork.WriteProgram();
            //hardWork.Hour = 12;
            //hardWork.WriteProgram();
            //hardWork.Hour = 13;
            //hardWork.WriteProgram();
            //hardWork.Hour = 16;
            //hardWork.WriteProgram();
            //hardWork.Hour = 17;
            //hardWork.WriteProgram();
            ////hardWork.TaskFinished = true;
            //hardWork.TaskFinished = false;
            //hardWork.Hour = 19;
            //hardWork.WriteProgram();
            //hardWork.Hour = 22;
            //hardWork.WriteProgram();

            #endregion V1

            //Context c = new Context(new ConcreteStateA());
            //c.Request();
            //c.Request();
            //c.Request();
            //c.Request();

            var hardWork = new Work();
            hardWork.Hour = 9;
            hardWork.WriteProgram();
            hardWork.Hour = 10;
            hardWork.WriteProgram();
            hardWork.Hour = 12;
            hardWork.WriteProgram();
            hardWork.Hour = 15;
            hardWork.WriteProgram();
            hardWork.Hour = 17;
            hardWork.WriteProgram();
            //hardWork.TaskFinished = true;
            hardWork.TaskFinished = false;
            hardWork.Hour = 20;
            hardWork.WriteProgram();
            hardWork.Hour = 22;
            hardWork.WriteProgram();
        }
    }
}