namespace EventLibrary.EventTypes;

public class TestEvent : Event
{
    private int _x;
    private string _name;

    public TestEvent(Type type, int x, string name) : base(type)
    {
        _x = x;
        _name = name;
    }

    public int GetX()
    {
        return _x;
    }

    public string GetName()
    {
        return _name;
    }

    public void PrintName()
    {
        Console.WriteLine("Test Event name is: " + _name);
    }
}