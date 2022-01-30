namespace EventLibrary;

public abstract class Event
{
    public enum Type
    {
        AdditionEvent,
        SoustractionEvent,
        MultiplicationEvent,
        DivisionEvent,
        TestEvent,
        MouseClickEvent,
        MouseHoldEvent,
        MouseDragEvent
    }

    public bool IsHandled;
    private readonly Type _type;

    protected Event(Type type)
    {
        _type = type;
    }

    public new Type GetType()
    {
        return _type;
    }
}