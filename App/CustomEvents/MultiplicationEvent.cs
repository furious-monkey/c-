namespace App.CustomEvents;

public class MultiplicationEvent : OperationEvent
{
    public new static string EventType => "EVENT_MULTIPLICATION_OPERATION";
    
    public MultiplicationEvent(int num1, int num2) : base(EventType, num1, num2)
    {
        
    }

    public override int Calculate()
    {
        return FirstNumber * SecondNumber;
    }
}