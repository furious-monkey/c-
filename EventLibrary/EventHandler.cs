namespace EventLibrary;

public class EventHandler : IEventListener
{
    private readonly List<IEventListener> _listeners;
    
    public void OnEvent(Event e)
    {
        foreach (var listener in _listeners)
        {
            listener.OnEvent(e);
        }
    }

    public void AddEventListener(IEventListener listener)
    {
        _listeners.Add(listener);
    }
    
    private EventHandler()
    {
        _listeners = new List<IEventListener>();
    }

    public static EventHandler Instance { get; } = new EventHandler();
}