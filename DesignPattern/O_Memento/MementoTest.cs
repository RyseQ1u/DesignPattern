using DesignPattern.O_Memento.Mementos;
using DesignPattern.O_Memento.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.O_Memento
{
    internal class MementoTest
    {
        public void Run()
        {
            #region V1

            //var p = new GameRole();
            ////获取初始状态
            //p.GetInitState();
            //p.StateDispaly();
            //Console.WriteLine();
            ////Save
            //var backup = new GameRole();
            //backup.Vitality = p.Vitality;
            //backup.Attack = p.Attack;
            //backup.Defense = p.Defense;
            ////Fight
            //p.Fight();
            //p.StateDispaly();
            //Console.WriteLine();
            ////Reload
            //p.Vitality = backup.Vitality;
            //p.Attack = backup.Attack;
            //p.Defense = backup.Defense;
            //p.StateDispaly();

            #endregion V1

            #region V2

            //Originator o = new Originator();
            //o.State = "On";
            //o.Show();
            //Caretaker c = new Caretaker();
            //c.Memento = o.CreateMemento();

            //o.State = "Off";
            //o.Show();

            //o.SetMemento(c.Memento);
            //o.Show();

            #endregion V2

            var p = new GameRole();
            p.GetInitState();
            p.StateDispaly();
            //save
            RoleStateCaretaker back = new RoleStateCaretaker();
            back.Memento = p.SaveState();
            //fight
            p.Fight();
            p.StateDispaly();
            p.RecoveryState(back.Memento);
            p.StateDispaly();
        }
    }
}