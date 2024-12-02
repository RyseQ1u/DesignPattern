namespace DesignPattern.J_Observer.Subject
{
    internal class Boss : ISubject
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

        #region 委托

        public Action UpdateAction;

        public void UpdateDelegate()
        {
            this.UpdateAction?.Invoke();
        }

        #endregion 委托

        #region 事件

        /// <summary>
        /// 什么是事件？事件是委托的一个实例，如Student的一个实例是张三，并且带有event关键字修饰，事件是一种更安全的特殊委托
        /// 只能在事件所在的类内部对其赋值和调用（invoke();),不能在外部对其赋值和调用，即使是子类。
        /// </summary>
        public event Action UpdateActionEvent;

        public void NotifyDelegateHandler()
        {
            this.UpdateActionEvent?.Invoke();
        }

        #endregion 事件
    }
}