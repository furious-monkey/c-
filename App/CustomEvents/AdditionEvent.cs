namespace App.CustomEvents;

public class AdditionEvent : OperationEvent
{
    public new static string EventType => "EVENT_ADDITION_OPERATION";

    public AdditionEvent(int num1, int num2) : base(EventType, num1, num2)
    {
        
    }

    public override int Calculate()
    {
        return FirstNumber + SecondNumber;
    }
}