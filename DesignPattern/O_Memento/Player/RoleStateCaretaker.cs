using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.O_Memento.Player
{
    /// <summary>
    /// 角色状态管理者
    /// </summary>
    internal class RoleStateCaretaker
    {
        public RoleStateMemento Memento { get; set; }
    }
}