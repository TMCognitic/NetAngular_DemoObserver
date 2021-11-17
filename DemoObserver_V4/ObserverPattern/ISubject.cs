namespace DemoObserver.ObserverPattern
{
    public interface ISubject
    {
        event Action<ISubject>? Broadcast;
    }
}