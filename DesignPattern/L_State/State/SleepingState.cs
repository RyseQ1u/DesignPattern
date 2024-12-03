using DesignPattern.L_State.Works;

namespace DesignPattern.L_State.State
{
    internal class SleepingState : AbsState
    {
        public override void WriteProgram(Work work)
        {
            Console.WriteLine($"现在 {work.Hour}点,睡着了。");
        }
    }
}