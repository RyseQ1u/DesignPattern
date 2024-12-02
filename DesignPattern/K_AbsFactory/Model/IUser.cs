using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.K_AbsFactory.Model
{
    internal interface IUser
    {
        public void Insert(User user);

        public User GetUser(int id);
    }
}