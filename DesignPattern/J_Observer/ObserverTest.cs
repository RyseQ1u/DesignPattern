using DesignPattern.J_Observer.Observer;
using DesignPattern.J_Observer.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.J_Observer
{
    internal class ObserverTest
    {
        public void Run()
        {
            #region V1

            //var hhs = new Boss();
            //var so = new StockObserver("同事1", hhs);
            //var no = new StockObserver("同事2", hhs);

            //hhs.Attach(so);
            //hhs.Attach(no);
            //hhs.Detach(no);
            //hhs.SubjectState = "我回来了";
            //hhs.Notify();

            #endregion V1

            var hhs = new Boss();
            var so = new StockObserver("同事1", hhs);
            var no = new NBAObserver("同事2", hhs);
            hhs.UpdateActionEvent += so.CloseStock;
            hhs.UpdateActionEvent += no.CloseNBA;

            //hhs.Attach(so);
            //hhs.Attach(no);
            //hhs.Detach(no);
            hhs.SubjectState = "我回来了";
            hhs.NotifyDelegateHandler();
        }
    }
}