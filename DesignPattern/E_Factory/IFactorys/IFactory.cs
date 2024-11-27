using DesignPattern.A_SimpleFactory.Operation;
using DesignPattern.E_Factory.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.E_Factory.IFactorys
{
    interface IFactory
    {
        BaseOperation CreateOperation();
    }

    interface ILeiFengFactory
    {
        LeiFeng CreateLeiFeng();
    }
}
