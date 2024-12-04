using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPattern.N_Composite.Companys;
using DesignPattern.N_Composite.Compoents;

namespace DesignPattern.N_Composite
{
    internal class ComponentTest
    {
        public void Run()
        {
            #region V1

            //var root = new Composite("root");
            //root.Add(new Leaf("Leaf A"));
            //root.Add(new Leaf("Leaf B"));
            //var comp1 = new Composite("Compostie I");
            //comp1.Add(new Leaf("Leaf IA"));
            //comp1.Add(new Leaf("Leaf IB"));
            //root.Add(comp1);
            //var comp2 = new Composite("Compostie  II");
            //comp2.Add(new Leaf("Leaf IIA"));
            //comp2.Add(new Leaf("Leaf IIB"));
            //comp1.Add(comp2);
            //root.Add(new Leaf("Leaf C"));
            //var d = new Leaf("Leaf D");
            //root.Add(d);
            //root.Remove(d);
            //root.Dispaly(1);

            #endregion V1

            var root = new ConcreteCompany("总公司");
            root.Add(new HRDepartment("总公司人力资源部"));
            root.Add(new FinanceDepartment("总公司财务部"));
            var comp1 = new ConcreteCompany("华北分公司");
            comp1.Add(new HRDepartment("华北分公司人力资源部"));
            comp1.Add(new FinanceDepartment("华北分公司财务部"));
            root.Add(comp1);
            var comp2 = new ConcreteCompany("天津办事处");
            comp2.Add(new HRDepartment("天津办事处人力资源部"));
            comp2.Add(new FinanceDepartment("天津办事处财务部"));
            comp1.Add(comp2);
            var comp3 = new ConcreteCompany("郑州分公司");
            comp3.Add(new HRDepartment("郑州分公司人力资源部"));
            comp3.Add(new FinanceDepartment("郑州分公司财务部"));
            comp1.Add(comp3);

            Console.WriteLine("结构图：");
            root.Display(1);
            Console.WriteLine("do something：");
            root.LineOfDuty();
        }
    }
}