using DesignPattern.J_Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.J_Observer.Observer
{
    internal class NBAObserver
    {
        #region V1

        //public NBAObserver(string name, ISubject subject) : base(name, subject)
        //{
        //}

        //public override void Update()
        //{
        //    Console.WriteLine($"{subject.SubjectState} {name} 关闭NBA，继续工作！");
        //}

        #endregion V1

        protected ISubject subject;
        protected string name;

        public NBAObserver(string name, ISubject subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public void CloseNBA()
        {
            Console.WriteLine($"{subject.SubjectState} {name} 关闭NBA，继续工作！");
        }
    }
}