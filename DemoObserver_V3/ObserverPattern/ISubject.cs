namespace DemoObserver.ObserverPattern
{
    public interface ISubject
    {
        void Attach(Action<ISubject> method);
        void Detach(Action<ISubject> method);
    }
}