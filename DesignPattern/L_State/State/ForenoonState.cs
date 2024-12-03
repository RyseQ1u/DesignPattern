using DesignPattern.L_State.Works;

namespace DesignPattern.L_State.State
{
    internal class ForenoonState : AbsState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 12)
            {
                Console.WriteLine($"现在 {work.Hour}点,上午，很有精神。");
            }
            else
            {
                work.SetState(new NoonState());
                work.WriteProgram();
            }
        }
    }
}