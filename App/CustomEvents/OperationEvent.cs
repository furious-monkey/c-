using EventLibrary;

namespace App.CustomEvents;

public abstract class OperationEvent : Event
{
    protected readonly int FirstNumber;
    protected readonly int SecondNumber;

    protected OperationEvent(string eventType, int num1, int num2) : base(eventType)
    {
        FirstNumber = num1;
        SecondNumber = num2;
    }

    public abstract int Calculate();
}