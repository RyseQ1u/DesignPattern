using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.O_Memento.Mementos
{
    internal class Memento
    {
        private string state;

        public string State { get; }

        public Memento(string state)
        {
            this.State = state;
        }
    }
}