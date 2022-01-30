namespace EventLibrary;

public class EventSystem
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
    
    // TODO: Create removeListener function
    
    private EventSystem()
    {
        _listeners = new List<IEventListener>();
    }

    public static EventSystem Instance { get; } = new EventSystem();
}