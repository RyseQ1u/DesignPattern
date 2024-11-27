using DesignPattern.A_SimpleFactory.Operation;

using DesignPattern.E_Factory.Product;
using DesignPattern.E_Factory.IFactorys;


namespace DesignPattern.E_Factory.Factory
{
    public class AddFactory : IFactory
    {
        public BaseOperation CreateOperation()
        {
            return new OperationAdd();
        }
    }
    public class SubFactory : IFactory
    {
        public BaseOperation CreateOperation()
        {
            return new OperationSub();
        }
    }
    public class MulFactory : IFactory
    {
        public BaseOperation CreateOperation()
        {
            return new OperationMul();
        }
    }
    public class DivFactory : IFactory
    {
        public BaseOperation CreateOperation()
        {
            return new OperationDiv();
        }
    }

    public class UndergraduateFactory : ILeiFengFactory
    {
        LeiFeng ILeiFengFactory.CreateLeiFeng()
        {
            return new Undergraduate();
        }
    }

    public class VolunteerFactory : ILeiFengFactory
    {
        LeiFeng ILeiFengFactory.CreateLeiFeng()
        {
            return new Volunteer();
        }
    }
}
