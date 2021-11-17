using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.ObserverPattern
{
    public class Subject : ISubject
    {
        private Action<ISubject>? _broadcast;

        public void Attach(Action<ISubject> method)
        {
            _broadcast += method;
        }

        public void Detach(Action<ISubject> method)
        {
            _broadcast -= method;
        }

        protected void Notify()
        {
            _broadcast?.Invoke(this);
        }
    }
}
