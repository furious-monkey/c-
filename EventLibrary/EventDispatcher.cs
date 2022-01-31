namespace EventLibrary;

public class EventDispatcher
{
    private readonly Event _event;
    private bool _response;

    public EventDispatcher(Event e)
    {
        _event = e;
    }

    public void Dispatch(string eventType, Func<Event, bool> callback)
    {
        if (_event.IsHandled || _event.EventType != eventType)
        {
            return;
        }

        _response = callback(_event);
        _event.IsHandled = _response;
    }
}