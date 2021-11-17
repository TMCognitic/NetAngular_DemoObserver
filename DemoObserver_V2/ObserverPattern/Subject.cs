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

        public void Attach(IObserver observer)
        {
            _broadcast += observer.Update;
        }

        public void Detach(IObserver observer)
        {
            _broadcast -= observer.Update;
        }

        protected void Notify()
        {
            _broadcast?.Invoke(this);
        }
    }
}
