using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.L_State.State;

namespace DesignPattern.L_State.Works
{
    internal class Work
    {
        public int Hour { get; set; }
        public bool TaskFinished { get; set; }

        #region V1

        //public void WriteProgram()
        //{
        //    if (Hour < 12)
        //    {
        //        Console.WriteLine($"现在 {Hour}点,上午，很有精神。");
        //    }
        //    else if (Hour < 13)
        //    {
        //        Console.WriteLine($"现在 {Hour}点,中午，饿了。");
        //    }
        //    else if (Hour < 18)
        //    {
        //        Console.WriteLine($"现在 {Hour}点,下午，还有精神。");
        //    }
        //    else
        //    {
        //        if (TaskFinished)
        //        {
        //            Console.WriteLine($"现在 {Hour}点,到点下班。");
        //        }
        //        else
        //        {
        //            if (Hour < 21)
        //            {
        //                Console.WriteLine($"现在 {Hour}点,加班中，快睡着了。");
        //            }
        //            else
        //            {
        //                Console.WriteLine($"现在 {Hour}点,睡着了。");
        //            }
        //        }
        //    }
        //}

        #endregion V1

        private AbsState state;

        public Work(AbsState absState)
        {
            this.state = absState;
        }

        public Work()
        {
            this.state = new ForenoonState();
        }

        public void SetState(AbsState absState)
        {
            this.state = absState;
        }

        public void WriteProgram()
        {
            this.state.WriteProgram(this);
        }
    }
}