namespace EventLibrary;

public abstract class Event
{
    public bool IsHandled;
    public readonly string EventType;

    protected Event(string eventType)
    {
        EventType = eventType;
    }
}