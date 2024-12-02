using DesignPattern.J_Observer.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.J_Observer.Subject
{
    internal class Secretary : ISubject
    {
        public string SubjectState
        {
            get { return action; }
            set
            {
                action = value;
            }
        }

        private string action;

        #region V1

        //private List<AbsObserver> observers = new List<AbsObserver>();

        //public void Attach(AbsObserver observer)
        //{
        //    observers.Add(observer);
        //}

        //public void Detach(AbsObserver observer)
        //{
        //    observers.Remove(observer);
        //}

        #endregion V1

        public event Action Update;

        public void NotifyDelegateHandler()
        {
            Update();
        }
    }
}