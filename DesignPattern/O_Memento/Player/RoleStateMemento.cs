using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.O_Memento.Player
{
    internal class RoleStateMemento
    {
        public int Vitality { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }

        public RoleStateMemento(int vitality, int attack, int defense)
        {
            Vitality = vitality;
            Attack = attack;
            Defense = defense;
        }
    }
}