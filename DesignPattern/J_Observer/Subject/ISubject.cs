using DesignPattern.J_Observer.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.J_Observer.Subject
{
    internal interface ISubject
    {
        #region V1

        //void Attach(AbsObserver observer);

        //void Detach(AbsObserver observer);

        #endregion V1

        void NotifyDelegateHandler();

        string SubjectState { get; set; }
    }
}