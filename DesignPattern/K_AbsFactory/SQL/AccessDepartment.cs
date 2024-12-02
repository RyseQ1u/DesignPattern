using DesignPattern.K_AbsFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.K_AbsFactory.SQL
{
    internal class AccessDepartment : IDepartment
    {
        public void Insert(Department user)
        {
            Console.WriteLine($"在Access 中插入部门 {user.Name}");
        }

        public Department GetDepartment(int id)
        {
            Console.WriteLine($"在Access 中查询部门 Id= {id}");
            return null;
        }
    }
}