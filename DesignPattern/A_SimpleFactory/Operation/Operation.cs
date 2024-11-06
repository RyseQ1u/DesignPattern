using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.A_SimpleFactory.Operation
{
    public class OperationAdd : BaseOperation
    {
        public override double GetResult()
        {
            double result = NumberA + NumberB;
            return result;
        }
    }

    public class OperationSub : BaseOperation
    {
        public override double GetResult()
        {
            double result = NumberA - NumberB;
            return result;
        }
    }

    public class OperationMul : BaseOperation
    {
        public override double GetResult()
        {
            double result = NumberA * NumberB;
            return result;
        }
    }

    public class OperationDiv : BaseOperation
    {
        public override double GetResult()
        {
            double result = NumberA / NumberB;
            if (NumberB == 0)
            {
                throw new Exception("除数不能为0");
            }
            return result;
        }
    }
}