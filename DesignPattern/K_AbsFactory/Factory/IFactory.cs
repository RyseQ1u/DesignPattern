using DesignPattern.K_AbsFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.K_AbsFactory.Factory
{
    internal interface IFactory
    {
        IUser CreateUser();

        IDepartment CreateDepartment();
    }
}