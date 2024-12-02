using DesignPattern.K_AbsFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.K_AbsFactory.SQL
{
    internal class SqlServerUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine($"在SQL Server 中插入用户{user.Name}");
        }

        public User GetUser(int id)
        {
            Console.WriteLine($"在SQL Server 中查询用户 Id= {id}");
            return null;
        }
    }
}