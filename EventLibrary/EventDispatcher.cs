namespace EventLibrary;

public class EventDispatcher
{
    private readonly Event _event;
    private bool _response;

    public EventDispatcher(Event e)
    {
        _event = e;
    }

    public void Dispatch(Event.Type type, Func<Event, bool> callback)
    {
        if (_event.IsHandled || _event.GetType() != type)
        {
            return;
        }

        _response = callback(_event);
        _event.IsHandled = _response;
    }
}