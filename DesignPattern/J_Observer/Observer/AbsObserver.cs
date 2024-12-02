using DesignPattern.J_Observer.Subject;

namespace DesignPattern.J_Observer.Observer
{
    internal abstract class AbsObserver
    {
        protected ISubject subject;
        protected string name;

        public AbsObserver(string name, ISubject subject)
        {
            this.name = name;
            this.subject = subject;
        }

        public abstract void Update();
    }
}