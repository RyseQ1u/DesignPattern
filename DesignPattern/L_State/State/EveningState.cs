using DesignPattern.L_State.Works;

namespace DesignPattern.L_State.State
{
    internal class EveningState : AbsState
    {
        public override void WriteProgram(Work work)
        {
            if (work.TaskFinished)
            {
                work.SetState(new RestState());
                work.WriteProgram();
            }
            else
            {
                #region V1

                //if (work.Hour < 21)
                //{
                //    Console.WriteLine($"现在 {work.Hour}点,加班中。");
                //}
                //else
                //{
                //    work.SetState(new SleepingState());
                //    work.WriteProgram();
                //}

                #endregion V1

                if (work.Hour < 21)
                {
                    Console.WriteLine($"现在 {work.Hour}点,加班中。");
                }
                else
                {
                    Console.WriteLine($"现在 {work.Hour}点,强制下班。");
                }
            }
        }
    }
}