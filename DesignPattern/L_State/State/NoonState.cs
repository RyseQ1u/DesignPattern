using DesignPattern.L_State.Works;

namespace DesignPattern.L_State.State
{
    internal class NoonState : AbsState
    {
        public override void WriteProgram(Work work)
        {
            if (work.Hour < 13)
            {
                Console.WriteLine($"现在 {work.Hour}点,中午，饿了。");
            }
            else
            {
                work.SetState(new AfternoonState());
                work.WriteProgram();
            }
        }
    }
}