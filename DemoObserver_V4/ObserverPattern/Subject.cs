using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoObserver.ObserverPattern
{
    public class Subject : ISubject
    {
        public event Action<ISubject>? Broadcast;

        protected void Notify()
        {
            Broadcast?.Invoke(this);
        }
    }
}
