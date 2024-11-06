using DesignPattern.A_SimpleFactory.Operation;

namespace DesignPattern.A_SimpleFactory
{
    public class OperationFactory
    {
        public static BaseOperation CreateOperation(string operationName)
        {
            BaseOperation op = null;
            switch (operationName)
            {
                case "+":
                    op = new OperationAdd();
                    break;

                case "-":
                    op = new OperationSub();
                    break;

                case "*":
                    op = new OperationMul();
                    break;

                case "/":
                    op = new OperationDiv();
                    break;
            }
            return op;
        }
    }
}