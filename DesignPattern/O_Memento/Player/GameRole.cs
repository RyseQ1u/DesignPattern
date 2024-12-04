using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.O_Memento.Player
{
    internal class GameRole
    {
        public int Vitality { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public void StateDispaly()
        {
            Console.WriteLine("角色当前状态：");
            Console.WriteLine($"体力：{this.Vitality}");
            Console.WriteLine($"攻击力：{this.Attack}");
            Console.WriteLine($"防御力：{this.Defense}");
        }

        public RoleStateMemento SaveState()
        {
            return new RoleStateMemento(Vitality, Attack, Defense);
        }

        public void RecoveryState(RoleStateMemento memento)
        {
            Vitality = memento.Vitality;
            Attack = memento.Attack;
            Defense = memento.Defense;
        }

        public void GetInitState()
        {
            Vitality = 100;
            Attack = 100;
            Defense = 100;
        }

        public void Fight()
        {
            Vitality = 0;
            Attack = 0;
            Defense = 0;
        }
    }
}