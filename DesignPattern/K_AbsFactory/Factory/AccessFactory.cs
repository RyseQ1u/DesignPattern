using DesignPattern.K_AbsFactory.Model;
using DesignPattern.K_AbsFactory.SQL;

namespace DesignPattern.K_AbsFactory.Factory
{
    internal class AccessFactory : IFactory
    {
        public IDepartment CreateDepartment()
        {
            return new AccessDepartment();
        }

        public IUser CreateUser()
        {
            return new AccessUser();
        }
    }
}