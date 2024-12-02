using DesignPattern.K_AbsFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.K_AbsFactory.SQL
{
    /// <summary>
    /// 用于访问Access
    /// </summary>
    internal class AccessUser : IUser
    {
        public User GetUser(int id)
        {
            Console.WriteLine($"在Access 中查询用户 Id= {id}");
            return null;
        }

        public void Insert(User user)
        {
            Console.WriteLine($"在Access 中插入用户{user.Name}");
        }
    }
}