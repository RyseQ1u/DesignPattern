using DesignPattern.J_Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.J_Observer.Observer
{
    internal class StockObserver
    {
        #region V1

        //public StockObserver(string name, ISubject subject) : base(name, subject)
        //{
        //}

        //public override void Update()
        //{
        //    Console.WriteLine($"{subject.SubjectState} {name} 关闭股票，继续工作！");
        //}

        #endregion V1

        protected ISubject subject;
        protected string name;

        public StockObserver(string name, ISubject subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public void CloseStock()
        {
            Console.WriteLine($"{subject.SubjectState} {name} 关闭股票，继续工作！");
        }
    }
}