using DesignPattern.A_SimpleFactory.Operation;
using DesignPattern.E_Factory.Factory;
using DesignPattern.E_Factory.IFactorys;
using DesignPattern.E_Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.E_Factory
{
    public class FactoryTest
    {
        public static void Run()
        {
            IFactory factory =new AddFactory();
            BaseOperation oper = factory.CreateOperation();
            oper.NumberA= 1;
            oper.NumberB= 2;
            double result =oper.GetResult();
        }

        public static void Run2()
        {
            ILeiFengFactory factory = new UndergraduateFactory();
            LeiFeng student = factory.CreateLeiFeng();
            student.BuyRice();
            student.Sweep();
            student.Wash();
        }
    }
}
