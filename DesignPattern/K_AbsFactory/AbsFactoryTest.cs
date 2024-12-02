using DesignPattern.E_Factory.IFactorys;
using DesignPattern.K_AbsFactory.Factory;
using DesignPattern.K_AbsFactory.Model;
using DesignPattern.K_AbsFactory.SQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IFactory = DesignPattern.K_AbsFactory.Factory.IFactory;

namespace DesignPattern.K_AbsFactory
{
    internal class AbsFactoryTest
    {
        public void Run()
        {
            var user = new User();
            var department = new Department();

            #region V1

            //var su = new SqlServerUser();
            //su.Insert(user);
            //su.GetUser(1);

            #endregion V1

            #region V2

            IFactory factory = new SqlServerFactory();
            IUser iu = factory.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            IFactory factoryD = new AccessFactory();
            IDepartment id = factoryD.CreateDepartment();
            id.Insert(department);
            id.GetDepartment(1);

            #endregion V2
        }
    }
}